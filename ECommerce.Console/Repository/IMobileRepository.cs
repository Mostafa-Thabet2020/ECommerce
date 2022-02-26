using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal interface IMobileRepository:IGenericCRUD<Mobile>
    {
        List<Mobile> GetAll(int UserId);
        bool IsExist(int Id);
        bool IsExist(string Mobile);
        bool IsExist(Mobile entity);
        bool IsUserHasMobile(int UserId);
    }
}
