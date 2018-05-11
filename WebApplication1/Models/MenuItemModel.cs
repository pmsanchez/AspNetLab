﻿using System.Collections.Generic;
using System.Linq;
namespace ASPNetexercises.Models
{
    public class MenuItemModel
    {
        private AppDbContext _db;
        public MenuItemModel(AppDbContext context)
        {
            _db = context;
        }
        public List<MenuItem> GetAll()
        {
            return _db.MenuItems.ToList();
        }
        public List<MenuItem> GetAllByCategory(int id)
        {
            return _db.MenuItems.Where(item => item.Category.Id == id).ToList();
        }
    }
}