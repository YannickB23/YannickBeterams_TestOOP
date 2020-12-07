using ReisLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisLibrary.Interfaces
{
    public interface ILoggable
    {
        LogMessage LogMessage();
    }
}
