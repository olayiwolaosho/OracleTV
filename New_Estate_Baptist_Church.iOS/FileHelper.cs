using System;
using System.IO;
using New_Estate_Baptist_Church.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace New_Estate_Baptist_Church.iOS
{
    public class FileHelper:IFileHelper
    {
       

        public string GetLocalFilePath(string filename)
        {
            string personalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder, "..", "Library");
            return Path.Combine(libraryFolder, filename);
        }
    }
}
