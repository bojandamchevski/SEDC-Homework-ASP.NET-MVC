using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class UserMapper
    {
        public static UserDetailsViewModel UserToUserDetailsViewModel(this User userStatic, User userDb)
        {
            return new UserDetailsViewModel
            {
                UserFullName = $"{userDb.FirstName} {userDb.LastName}",
                UserAddress = userDb.Address
            };
        }
    }
}
