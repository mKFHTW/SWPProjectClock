using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoCommand_Click(object sender, EventArgs e)
        {
            //ArrayList _loadedPlugins;

            command newCommand = new command(tBoxCommandLine.Text);
            ICommand obj = null;

            switch (newCommand.type)
            {
                case "set":
                    obj = new setCommand();
                    break;
                case "help":
                    obj = new helpCommand();
                    break;
                case "dec":
                    obj = new decCommand();
                    break;
                case "inc":
                    obj = new incCommand();
                    break;
                case "undo":
                    obj = new undoCommand();
                    break;
                case "redo":
                    obj = new redoCommand();
                    break;
                default:
                    break;
            }

            obj.doCommand(newCommand);

            /*pluginManager PluginManager = new pluginManager();
            _loadedPlugins = PluginManager.LoadPlugins("/../../.", "*.cs", typeof(ICommand));

            foreach (ICommand plug in _loadedPlugins)
            {                
                if (plug.getCommandName == newCommand.type)                
                    plug.doCommand(newCommand);                  
                
            }*/
        }
    }
}
