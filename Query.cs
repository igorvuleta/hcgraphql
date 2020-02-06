using hcgraphqlnew.Models;
using hcgraphqlnew.Repository.CategoriesRepository;
using hcgraphqlnew.Repository.CustomerCustomerDemoRepository;
using hcgraphqlnew.Repository.CustomerDemographicsRepository;
using hcgraphqlnew.Repository.CustomersRepository;
using hcgraphqlnew.Repository.EmployeesRepository;
using hcgraphqlnew.Repository.EmployeeTerritoriesRepository;
using hcgraphqlnew.Repository.OrderDetailsRepository;
using hcgraphqlnew.Repository.OrdersRepository;
using hcgraphqlnew.Repository.ProductsRepository;
using hcgraphqlnew.Repository.RegionRepository;
using hcgraphqlnew.Repository.ShippersRepository;
using hcgraphqlnew.Repository.SuppliersRepository;
using hcgraphqlnew.Repository.TerritoriesRepository;
using HotChocolate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace hcgraphqlnew
{
    public class Query
    {

      public IQueryable<Products> GetProducts([Service]IProductsRepository repository) => repository.GetProducts();
      public IQueryable<Categories> GetCategories([Service]ICategoriesRepository repository) => repository.GetCategories();
      public IQueryable<Customers> GetCustomers([Service]ICustomersRepository repository) => repository.GetCustomers();
      public IQueryable<Orders> GetOrders([Service]IOrdersRepository repository) => repository.GetOrders();
      public IQueryable<OrderDetails> GetOrderDetails([Service]IOrderDetailsRepository repository) => repository.GetOrderDetails();
      public IQueryable<Suppliers> GetSuppliers([Service]ISuppliersRepository repository) => repository.GetSuppliers();
      public IQueryable<Shippers> GetShippers([Service]IShippersRepository repository) => repository.GetShippers();
      public IQueryable<Employees> GetEmployees([Service]IEmployeesRepository repository) => repository.GetEmployees();
      public IQueryable<Territories> GetTerritories([Service]ITerritoriesRepository repository) => repository.GetTerritories();
      public IQueryable<Region> GetRegions([Service]IRegionRepository repository) => repository.GetRegions();
      public IQueryable<EmployeeTerritories> GetEmployeeTerritories([Service]IEmployeeTerritoriesRepository repository) => repository.GetEmployeeTerritories();
      public IQueryable<CustomerDemographics> GetCustomerDemographics([Service]ICustomerDemographicsRepository repository) => repository.GetCustomerDemographics();
      public IQueryable<CustomerCustomerDemo> GetCustomerCustomerDemo([Service]ICustomerCustomerDemoRepository repository) => repository.GetCustomerCustomerDemos();
   }
}

 

