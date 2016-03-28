using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musique.Interface
{
    public interface IStyle
    {
        int BpmMin { get; }
        int BpmMax { get; }
        int AverageBpm { get; }

        INote StyleTime(INote note);
    }
}
