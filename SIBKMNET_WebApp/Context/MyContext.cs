using Microsoft.EntityFrameworkCore;
using SIBKMNET_WebApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIBKMNET_WebApp.ViewModels;

namespace SIBKMNET_WebApp.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }

        public static IEnumerable Province { get; internal set; }

        //Mengatur Connection String
        //Menambahkan model untuk diolah dan / atau migrasi

        /*
         * Code First
         * Database First
         */

        public DbSet<Province> Provinces { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SIBKMNET_WebApp.ViewModels.ChangePassword> ChangePassword { get; set; }
    }
}
