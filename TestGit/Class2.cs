using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    public class Class2
    {
        private string alt1;
        private string alt2;

        //public string Alt1
        //{
        //    get { return alt1; }
        //    set { alt1 = value; }
        //}


        //public string Alt2
        //{
        //    get { return alt2; }
        //    set { alt2 = value; }
        //}

        public string Alt1 { get => alt1; set => alt1 = value; }
        public string Alt2 { get => alt2; set => alt2 = value; }

    }
}
