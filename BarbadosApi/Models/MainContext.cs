using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarbadosApi.Models
{
    public class MainContext : DbContext
    {
        //Для работы с данными одноименных таблиц
        public DbSet<Client> Clients { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Message> Messages { get; set; }

        //Конктруктор, принимающий настройки по работе с базой данных
        public MainContext(DbContextOptions<MainContext> dbContextOptions)
        : base(dbContextOptions)
        {
            Database.EnsureCreated();
        }
    }
}
