using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Vezeeta.Models;

namespace Veezeta.Models
{
    public class Entites : DbContext
    {
        public Entites()
        {
        }
        public Entites(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Client> AllClients
        {
            get { return Clients; }
            set { Clients = value; }
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Appointment> AllAppointments
        {
            get { return Appointments; }
            set { Appointments = value; }
        }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Specialization> AllSpecializations
        {
            get { return Specializations; }
            set { Specializations = value; }
        }

        public DbSet<Discount> AllDiscounts
        {
            get { return Discounts; }
            set { Discounts = value; }
        }
        public DbSet<Docter> Doctors { get; set; }
        public DbSet<Docter> AllDoctors
        {
            get { return Doctors; }
            set { Doctors = value; }
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Booking> AllBookings
        {
            get { return Bookings; }
            set { Bookings = value; }
        }

        public DbSet<TimeSlot> AllTimeSlots
        {
            get { return TimeSlots; }
            set { TimeSlots = value; }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=VezeetaDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Client>().ToTable(""); // Mapping Users to the Users table
            modelBuilder.Entity<Docter>().ToTable("Doctors"); // Mapping Doctors to a separate Doctors table
            base.OnModelCreating(modelBuilder);
        }
    }
}
