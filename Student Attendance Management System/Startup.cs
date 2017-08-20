using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Student_Attendance_Management_System.Startup))]
namespace Student_Attendance_Management_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
