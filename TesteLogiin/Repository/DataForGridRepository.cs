using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using TesteLogiin.Data;
using TesteLogiin.DataModel;

namespace TesteLogiin.Repository
{
    public class DataForGridRepository : IDisposable
    {
        


        public DataForGridRepository()
        {
        }

        public DataForGrid selectByEmail(string data)
        {
     
            using(var teste = new DataContext())
            {
                var getData = teste.DataForGrids.ToList().Where(x => x.email == data).FirstOrDefault();
                return getData;
                
            }
            
        }

        public IEnumerable<DataForGrid> selectAll(DataForGrid data)
        {
            using (var teste = new DataContext())
            {
                var getData = teste.DataForGrids.ToList().Where(x => x.email == data.email);
                return getData;

            }
            
        }

        public void Dispose()
        {

        }
    }
}
