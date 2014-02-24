using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem_v_0_1.User
{
    class CurrentUser
    {

        private string userId;

        public void SetUserId(string uId)
        {

            userId = uId;

        }

        public string getUserId()
        {

            return userId;

        }
    }


}
