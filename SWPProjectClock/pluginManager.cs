using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    class pluginManager
    {
        public ArrayList LoadPlugins(string path, string pattern, Type type)
        {
            ArrayList Plugins = new ArrayList();

            string fullPath = AppDomain.CurrentDomain.BaseDirectory + path;

            foreach (string file in System.IO.Directory.GetFiles(fullPath, pattern))
            {
                try
                {
                    System.Reflection.Assembly a = System.Reflection.Assembly.LoadFrom(file);
                    
                    foreach (Type t in a.GetExportedTypes())
                    {

                        if (t.IsPublic && t.IsClass && t.GetInterface(type.FullName) != null)
                        {
                            Plugins.Add(a.CreateInstance(t.FullName));
                            MessageBox.Show(a.ToString() + " is a valid plugin.");
                            //Console.WriteLine();
                        }
                        else
                        {
                            MessageBox.Show(a.ToString() + " is not a valid plugin.");
                        }
                    }
                   // Console.WriteLine();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   // Console.WriteLine();
                }
            }

            return Plugins;
        }
    
    }
}
