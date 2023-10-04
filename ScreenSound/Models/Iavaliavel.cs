using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal interface Iavaliavel
    {
        void AdicionarNota(Avaliaçao nota);
        double Media { get; }

    }
}
