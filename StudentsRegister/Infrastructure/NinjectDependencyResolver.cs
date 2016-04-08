using Ninject;
using StudentsRegister.Abstract;
using StudentsRegister.Concrete;
using StudentsRegister.Infrastructure.Abstract;
using StudentsRegister.Infrastructure.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsRegister.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {

        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IStudentsRepository>().To<EFStudentRepository>();
            kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }

    }
}