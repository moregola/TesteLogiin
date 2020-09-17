using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteLogiin.DataModel;

namespace TesteLogiin.Data
{
    public class DataInsert
    {
        public static void Initialize(DataContext _context)
        {
            _context.Database.EnsureCreated();


            var data = new DataForGrid[]
            {
                   new DataForGrid{Id=1, Name="Teste1", AccountNumber=123456, AccountBalance=150.10, email="moregola@gmail.com"}
            };
            foreach (DataForGrid p in data)
            {
                _context.DataForGrids.Add(p);
            }

            _context.SaveChanges();

            /*TODO ALIMENTAR TABLES*/
        }
    }
}
