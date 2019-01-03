using System;
using System.IO;
using New_Estate_Baptist_Church.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]

namespace New_Estate_Baptist_Church.Droid
{
    public class FileHelper:IFileHelper
    {
       

        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}
