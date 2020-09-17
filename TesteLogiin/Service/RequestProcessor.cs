using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteLogiin.DataModel;
using TesteLogiin.Repository;
using TesteLogiin.Service.Contracts;


namespace TesteLogiin.Service
{
    public class RequestProcessor : IRequestProcessor
    {
        private readonly DataForGridRepository dataRepo = new DataForGridRepository();
        public DataForGrid GetData(string dataItem)
        {
            return dataRepo.selectByEmail(dataItem);
        }

        public IEnumerable<DataForGrid> GetListData(string dataItem)
        {
            return dataRepo.selectAll(dataRepo.selectByEmail(dataItem));
        }

        public void Save(DataForGrid dataItem)
        {
            throw new NotImplementedException();
        }

        public bool Update(DataForGrid dataItem)
        {
            throw new NotImplementedException();
        }
    }
}
