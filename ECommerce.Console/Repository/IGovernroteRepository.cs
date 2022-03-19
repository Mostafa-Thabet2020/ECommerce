using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository
{
    public interface IGovernroteRepository : IGenericCRUD<Governrote>, IValidation<Governrote>
    {
        void AddList(List<Governrote> governrotes);
        bool IsEmpty();
    }
}
