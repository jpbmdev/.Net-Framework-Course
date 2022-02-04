using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    internal interface IIndexadorBase
    {
        bool this[int index] {get; set;}    
    }
}
