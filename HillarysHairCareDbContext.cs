using Microsoft.EntityFrameworkCore;
using HillarysHairCare.Models;

public class HillarysHairCareDbContext : DbContext
{
    public DbSet<Appointment> Appointments {get; set;}
    public DbSet<AppointmentService> AppointmentServices {get; set;}
    public DbSet<Customer> Customers {get; set;}
    public DbSet<Service> Services {get; set;}
    public DbSet<Stylist> Stylists {get; set;}

    public HillarysHairCareDbContext(DbContextOptions<HillarysHairCareDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(new Customer[]
        {
            new Customer {Id = 1, Name = "Housein", Phone = "834-8431-8484", Email = "hou@yahoo.com"},
            new Customer {Id = 2, Name = "Zach", Phone = "141-765-3221", Email = "Zach@gmail.com"},
            new Customer {Id = 3, Name = "Fields", Phone = "952-348-8568", Email = "Fields@hotmail.com"},
            new Customer {Id = 4, Name = "Sue", Phone = "847-625-8451", Email = "Sue@gmail.com"}
        });

        modelBuilder.Entity<Service>().HasData(new Service[]
        {
            new Service {Id = 1, Name = "Haircut", Price = 20M},
            new Service {Id = 2, Name = "Beard Trim", Price = 15.5M},
            new Service {Id = 3, Name = "Coloring", Price = 40M}
        });

        modelBuilder.Entity<Stylist>().HasData(new Stylist[]
        {
            new Stylist {Id = 1, Name = "Luca", IsActive = true},
            new Stylist {Id = 2, Name = "JoeMama", IsActive = true},
            new Stylist {Id = 3, Name = "Ooglata", IsActive = true},
            new Stylist {Id = 4, Name = "Salad", IsActive = false}
        });

        modelBuilder.Entity<Appointment>().HasData(new Appointment[]
        {
            new Appointment {Id = 1, Date = DateTime.Today, StylistId = 1, CustomerId = 2},
            new Appointment {Id = 2, Date = DateTime.Today, StylistId = 2, CustomerId = 1}
        });

        modelBuilder.Entity<AppointmentService>().HasData(new AppointmentService[]
        {
            new AppointmentService {Id = 1, ServiceId = 1, AppointmentId = 2},
            new AppointmentService {Id = 2, ServiceId = 2, AppointmentId = 2},
            new AppointmentService {Id = 3, ServiceId = 3, AppointmentId = 1},
            new AppointmentService {Id = 4, ServiceId = 2, AppointmentId = 1}
        });
    }
}