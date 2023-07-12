using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Services.UsersService
{
    public interface IUsersService
    {
        public Task<List<Users>> GetAllUsers();

        public Task<Users> GetSingleUserByFirstName(string firstname);

        public Task<Users> GetSingleUserByMiddleName(string middlename);

        public Task<Users> GetSingleUserByLastName(string lastname);

        public Task<Users> GetSingleUserByGender(string gender);

        public Task<Users> GetSingleUserByUserName(string username);

        public Task<Users> GetSingleUserByPasswordHash(string passwordhash);

        public Task<List<Users>> AddUser(Users user);

        public Task<List<Users>> UpdateUserByFirstName(string firstname, Users request);

        public Task<List<Users>> UpdateUserByMiddleName(string middlename, Users request);

        public Task<List<Users>> UpdateUserByLastName(string lastname, Users request);

        public Task<List<Users>> UpdateUserByGender(string gender, Users request);

        public Task<List<Users>> UpdateUserByUserName(string username, Users request);

        public Task<List<Users>> UpdateUserByPasswordHash(string passwordhash, Users request);

        public Task<List<Users>> DeleteUserByFirstName(string firstname);

        public Task<List<Users>> DeleteUserByMiddleName(string middlename);

        public Task<List<Users>> DeleteUserByLastName(string lastname);

        public Task<List<Users>> DeleteUserByGender(string gender);

        public Task<List<Users>> DeleteUserByUserName(string username);

        public Task<List<Users>> DeleteUserByPasswordHash(string passwordhash);
    }
    }



