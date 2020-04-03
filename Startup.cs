using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WAD_Exam.Startup))]
namespace WAD_Exam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
