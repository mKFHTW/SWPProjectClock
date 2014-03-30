using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    class HelpCommand : ICommand
    {
        public void doCommand(Command cmd)
        {
            MessageBox.Show(@"set {–h <hour>} {-m <minutes>} {-s <seconds>}	setzt die Werte der Uhr 
inc {–h} {–m} {–s}	Incrementiert Stunde, Minute, Sekunde – können optional in beliebiger Reihenfolge angegeben werden 
dec {–h} {–m} {–s}	Decrementiert Stunde, Minute, Sekunde – können optional angegeben werden 
undo	macht die letzten Befehle rückgängig (achten Sie auf eine sinnvolle Ausgabe) 
redo	wiederholt den letzten Befehl oder macht das letzte undo wieder rückgängig 
show –t <type> {-z <timezone>} {-x <x> -y <y>}	Öffnet ein Grafikfenster an x, y und zeigt eine Uhr vom Typ <type> an für eine bestimmte Zeitzone (Städte) 
");
            CommandQueue.Instance.Add(cmd);
        }

        public void undoCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
