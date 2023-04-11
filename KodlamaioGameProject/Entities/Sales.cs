using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Entities
{
    public class Sales:IEntity
    {
        public Game gamer { get; set; }
        public Campaign campaign { get; set; }
    }
}
