﻿using WTOPMDb.Models;

namespace WTOPMDb.Data
{
    public interface IWtopmDbRepository
    {
        void Add<T> (T entity) where T : class;
        void Delete<T> (T entity) where T : class; 
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}
