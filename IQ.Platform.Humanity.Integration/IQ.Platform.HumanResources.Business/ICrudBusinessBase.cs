using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ.Platform.HumanResources.Business
{
    public interface ICrudBusinessBase<TBusinessModel, TPrimaryKey> where TBusinessModel:class,new()
    {
        TBusinessModel Create(TBusinessModel businesssModel);

        TBusinessModel Update(TBusinessModel businessModel);

        TBusinessModel RetrieveByPrimaryKey(TPrimaryKey key);

        List<TBusinessModel> RetrieveAll();
    }
}
