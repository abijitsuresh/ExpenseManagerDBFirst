using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpenseManagerDBFirst.Startup))]
namespace ExpenseManagerDBFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
