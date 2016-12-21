using System;
using Microsoft.Practices.Unity;
using Northwind.Entities.Models;
using Northwind.Service;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;

namespace Northwind.Web
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            container
                .RegisterType<IDataContextAsync, NorthwindContext>(new PerRequestLifetimeManager())
                .RegisterType<IUnitOfWorkAsync, UnitOfWork>(new PerRequestLifetimeManager())
                .RegisterType<IRepositoryAsync<tblUser>, Repository<tblUser>>()
                .RegisterType<IRepositoryAsync<tblUserFamilyInfo>, Repository<tblUserFamilyInfo>>()
                 .RegisterType<IRepositoryAsync<tblUserQualificationInfo>, Repository<tblUserQualificationInfo>>()
                 .RegisterType<IRepositoryAsync<tblEmployeeJoiningInitiateProcess>, Repository<tblEmployeeJoiningInitiateProcess>>()

                   .RegisterType<IRepositoryAsync<tblDepartment>, Repository<tblDepartment>>()

                     .RegisterType<IRepositoryAsync<tblDesignation>, Repository<tblDesignation>>()

                       .RegisterType<IRepositoryAsync<tblDivision>, Repository<tblDivision>>()

                         .RegisterType<IRepositoryAsync<tblUserAddress>, Repository<tblUserAddress>>()

                           .RegisterType<IRepositoryAsync<tblUserDetailsofLatestPreviousEmployment>, Repository<tblUserDetailsofLatestPreviousEmployment>>()
                           .RegisterType<IRepositoryAsync<tblUserDetailsofPreviousEmployment>, Repository<tblUserDetailsofPreviousEmployment>>()
                           .RegisterType<IRepositoryAsync<tblUserPersonsforReference>, Repository<tblUserPersonsforReference>>()
                           .RegisterType<IRepositoryAsync<tblUserMiscellaneousDetail>, Repository<tblUserMiscellaneousDetail>>()
                           .RegisterType<IRepositoryAsync<tblUserLanguage>, Repository<tblUserLanguage>>()


                //.RegisterType<IRepositoryAsync<Product>, Repository<Product>>()
                //.RegisterType<IProductService, ProductService>()
                .RegisterType<IUserService, UserService>()
                //.RegisterType<INorthwindStoredProcedures, NorthwindContext>(new PerRequestLifetimeManager())
                .RegisterType<IStoredProcedureService, StoredProcedureService>();
        }
    }
}





