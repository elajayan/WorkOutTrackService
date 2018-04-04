using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOutDBLayer.Model;

namespace WorkOutDBLayer
{
    public class MyContext : DbContext
    {

        public MyContext() : base("WorkoutTracker_Ela")
        {
            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<WorkOut> WorkOutCollection { get; set; }

        public DbSet<Workout_Active> WorkOutsActive { get; set; }

    }
}
