﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COPYPASTE_TheTragedyOfDarthPlagueisTheWise
{
    class Program
    {

        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Clipboard.SetText("Did you ever hear the Tragedy of Darth Plagueis the Wise? It's a Sith legend. Darth Plagueis was a Dark Lord of the Sith so powerful and so wise, he could use the Force to influence the midi-chlorians to create...life. He had such a knowledge of the Dark Side, he could even keep the ones he cared about...from dying. He became so powerful, the only thing he was afraid of was losing his power...which, eventually of course, he did. Unfortunately, he taught his apprentice everything he knew. Then his apprentice killed him in his sleep. Ironic. He could save others from death...but not himself.");
            
        }
    }
}
