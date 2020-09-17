using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteLogiin.DataModel;



namespace TesteLogiin.Service.Contracts
{
    public interface IRequestProcessor
    {
        public DataForGrid GetData(string dataItem);
        public IEnumerable<DataForGrid> GetListData(string dataItem);
        public void Save(DataForGrid dataItem);
        public bool Update(DataForGrid dataItem);

    }
}
