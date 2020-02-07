using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP_Final_4046.Models
{
    public interface ISportRepo
    {
        IEnumerable<Sport> GetSports();
    }
}
