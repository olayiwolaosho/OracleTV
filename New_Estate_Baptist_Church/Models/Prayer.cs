using System;

namespace New_Estate_Baptist_Church.ChurchPlusServices
{
    public class Prayer
    {

        public string name
        {
            get;
            set;
        }
        public string phonenumber
        {
            get;
            set;
        }
        public string id
        {
            get;
            set;
        }
        public string subject
        {
            get;
            set;
        }

        public string details
        {
            get;
            set;
        }

        public Guid? TenantID
        {
            get;
            set;
        }
        public string makePublic
        {
            get;
            set;
        }
        public bool SendAsEmail
        {
            get;
            set;
        }

        public bool sendAsEmail
        {
            get;
            set;
        }

        public DateTime? dateSent
        {
            get;
            set;
        }
    }
}