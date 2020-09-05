using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// The 'Component' interface
    /// </summary>
    public interface Vehicle
    {
        string Make { get; }
        string Model { get; }
        double Price { get; }
    }
}
