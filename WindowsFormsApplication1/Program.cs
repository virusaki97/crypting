using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        

        public static string encrypt(string input, string password)
        {
            int i, j, len, len2;
            len = input.Length;
            len2 = password.Length;
            char[] output = new char[len];     
            for(i = 0, j = 0; i < len; i++, j++)
            {
                if (j == len2) j = 0;

                output[i] = (char) (input[i] + password[j]);
            }
            return new string(output);
        }

        public static string decrypt(string input, string password)
        {
            int i, j, len, len2;
            len = input.Length;
            len2 = password.Length;
            char[] output = new char[len];
            for (i = 0, j = 0; i < len; i++, j++)
            {
                if (j == len2) j = 0;

                output[i] = (char)(input[i] - password[j]);
            }
            return new string(output);
        }
   
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
