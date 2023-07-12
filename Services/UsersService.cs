using System;
using Microsoft.AspNetCore.Mvc;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Services;
using SIBLEYBLAYOPERA.Services.UsersService;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;
using System.Reflection;
using Microsoft.AspNetCore.Identity;


namespace SIBLEYBLAYOPERA.Services.UsersService
{
    public class UsersService : IUsersService
{
    private readonly DataContext _context;

    public UsersService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Users>>GetAllUsers()
    {
        var users = await _context.Users.ToListAsync();
        return users;
    }

    public async Task<Users>GetSingleUserByFirstName(string firstname)
    {
            var user = await _context.Users.Where(u => u.FirstName == firstname).FirstOrDefaultAsync();
        if (user is null)
            return null;

        return user;
    }

        public async Task<Users>GetSingleUserByMiddleName(string middlename)
        {
            var user = await _context.Users.Where(u => u.MiddleName == middlename).FirstOrDefaultAsync();
            if (user is null)
                return null;

            return user;
        }

        public async Task<Users>GetSingleUserByLastName(string lastname)
        {
            var user = await _context.Users.Where(u => u.LastName == lastname).FirstOrDefaultAsync();
            if (user is null)
                return null;

            return user;
        }

        public async Task<Users>GetSingleUserByGender(string gender)
        {
            var user = await _context.Users.Where(u => u.Gender == gender).FirstOrDefaultAsync();
            if (user is null)
                return null;

            return user;
        }

        public async Task<Users>GetSingleUserByUserName(string username)
        {
            var user = await _context.Users.Where(u => u.UserName == username).FirstOrDefaultAsync();
            if (user is null)
                return null;

            return user;
        }

        public async Task<Users>GetSingleUserByPasswordHash(string passwordhash)
        {
            var user = await _context.Users.Where(u => u.PasswordHash == passwordhash).FirstOrDefaultAsync();
            if (user is null)
                return null;

            return user;
        }

        public async Task<List<Users>>AddUser(Users user)
        {

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>>UpdateUserByFirstName(string firstname, Users request)
        {
            var user = await _context.Users.Where(u => u.FirstName == firstname).FirstOrDefaultAsync();
            if (user is null)
            return null;

        user.FirstName = request.FirstName;
        await _context.SaveChangesAsync();

        return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>>UpdateUserByMiddleName(string middlename, Users request)
        {
            var user = await _context.Users.Where(u => u.MiddleName == middlename).FirstOrDefaultAsync();
            if (user is null)
                return null;

            user.MiddleName = request.MiddleName;
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>>UpdateUserByLastName(string lastname, Users request)
        {
            var user = await _context.Users.Where(u => u.LastName == lastname).FirstOrDefaultAsync();
            if (user is null)
                return null;

            user.LastName = request.LastName;
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>>UpdateUserByGender(string gender, Users request)
        {
            var user = await _context.Users.Where(u => u.Gender == gender).FirstOrDefaultAsync();
            if (user is null)
                return null;

            user.Gender = request.Gender;
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>>UpdateUserByUserName(string username, Users request)
        {
            var user = await _context.Users.Where(u => u.UserName == username).FirstOrDefaultAsync();
            if (user is null)
                return null;

            user.UserName = request.UserName;
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>>UpdateUserByPasswordHash(string passwordhash, Users request)
        {
            var user = await _context.Users.Where(u => u.PasswordHash == passwordhash).FirstOrDefaultAsync();
            if (user is null)
                return null;

            user.PasswordHash = request.PasswordHash;
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>>DeleteUserByFirstName(string firstname)
        {
            var user = await _context.Users.Where(u => u.FirstName == firstname).FirstOrDefaultAsync();
            if (user is null)
            return null;

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>>DeleteUserByMiddleName(string middlename)
        {
            var user = await _context.Users.Where(u => u.MiddleName == middlename).FirstOrDefaultAsync();
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>>DeleteUserByLastName(string lastname)
        {
            var user = await _context.Users.Where(u => u.LastName == lastname).FirstOrDefaultAsync();
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>>DeleteUserByGender(string gender)
        {
            var user = await _context.Users.Where(u => u.Gender == gender).FirstOrDefaultAsync();
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>>DeleteUserByUserName(string username)
        {
            var user = await _context.Users.Where(u => u.UserName == username).FirstOrDefaultAsync();
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> DeleteUserByPasswordHash(string passwordhash)
        {
            var user = await _context.Users.Where(u => u.PasswordHash == passwordhash).FirstOrDefaultAsync();
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }
    }
}

