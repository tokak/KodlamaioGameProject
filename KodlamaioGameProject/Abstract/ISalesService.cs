using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Abstract
{
    public interface ISalesService
    {
        //Kampanyalı ve kampanyasız oyun satış ekleme,silme,güncelleme
        void Add(Game game, Campaign campaign =null);
        void Delete(int id);
        void Update(Game game,Campaign campaign=null);

    }
}
