using Autofac;
using Autofac.Integration.Mvc;
using BusinessLayer.Abstract;
using BusinessLayer.Interaction;
using DataLayer.Abstract;
using DataLayer.Interaction;
using System.Web.Mvc;

namespace AspTrainingApp.Utils
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            // получаем экземпляр контейнера
            var builder = new ContainerBuilder();

            // регистрируем контроллер в текущей сборке
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // регистрируем споставление типов
            builder.RegisterType<DLEntry>().As<IDLEntry>();
            builder.RegisterType<BLEntry>().As<IBLEntry>();
            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}