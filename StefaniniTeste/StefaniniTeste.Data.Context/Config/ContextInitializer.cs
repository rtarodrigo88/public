using System.Data.Entity;
using StefaniniTeste.Data.Context.Interfaces;

namespace StefaniniTeste.Data.Context.Config
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<StefaniniTesteContext>
    {
        protected override void Seed(StefaniniTesteContext context)
        {
            context.SaveChanges();
        }
    }
}
