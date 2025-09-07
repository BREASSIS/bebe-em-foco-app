using BebeEmFoco.Application.Interfaces.Appointments;
using BebeEmFoco.Application.Interfaces.Medications;
using BebeEmFoco.Application.Interfaces.Pregnants;
using BebeEmFoco.Application.Interfaces.Users;
using BebeEmFoco.Application.Interfaces.Vaccines;
using BebeEmFoco.Application.Services.Appointments;
using BebeEmFoco.Application.Services.Medications;
using BebeEmFoco.Application.Services.Pregnants;
using BebeEmFoco.Application.Services.Users;
using BebeEmFoco.Application.Services.Vaccines;
using BebeEmFoco.Domain.Interfaces.Appointments;
using BebeEmFoco.Domain.Interfaces.Medications;
using BebeEmFoco.Domain.Interfaces.Pregnants;
using BebeEmFoco.Domain.Interfaces.Users;
using BebeEmFoco.Domain.Interfaces.Vaccines;
using BebeEmFoco.Infrastructure.Repositories.Appointments;
using BebeEmFoco.Infrastructure.Repositories.Medications;
using BebeEmFoco.Infrastructure.Repositories.Pregnants;
using BebeEmFoco.Infrastructure.Repositories.Users;
using BebeEmFoco.Infrastructure.Repositories.Vaccines;

namespace BebeEmFoco.Api.Configurations
{
    public static class DependencyInjection
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            // Services
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IMedicationService, MedicationService>();
            services.AddScoped<IVaccineService, VaccineService>();
            services.AddScoped<IPregnantService, PregnantService>();
            services.AddScoped<IUserService, UserService>();



            // Repositories
            services.AddScoped<IAppointmentRepository, AppointamentRepository>();
            services.AddScoped<IMedicationRepository, MedicationRepository>();
            services.AddScoped<IVaccineRepository, VaccineRepository>();
            services.AddScoped<IPregnantRepository, PregnantRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
