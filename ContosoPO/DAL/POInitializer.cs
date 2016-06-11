using ContosoPO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContosoPO.DAL
{
    public class POInitializer : CreateDatabaseIfNotExists<POContext>
    {
        protected override void Seed(POContext context)
        {
            base.Seed(context);

            // Create some employees
            var employees = new List<Employee>
            {
                new Employee
                {
                    EmployeeID = 301,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@contoso.com"
                },
                new Employee
                {
                    EmployeeID = 512,
                    FirstName = "Clark",
                    LastName = "Griswold",
                    Email = "clark.griswold@contoso.com"
                }
            };
            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();

            // Create some default purchase orders
            var purchaseOrders = new List<PurchaseOrder>
            {
                new PurchaseOrder {
                    PurchaseOrderID = 1001,
                    EmployeeID = 301,
                    Title ="Finance dept. hardware refresh",
                    StartDate = DateTime.Parse("2016-07-01"),
                    EndDate = DateTime.Parse("2016-09-01")
                },
                new PurchaseOrder {
                    PurchaseOrderID = 1002,
                    EmployeeID = 512,
                    Title ="Azure Essentials Development - Phase 1",
                    StartDate = DateTime.Parse("2016-07-01"),
                    EndDate = DateTime.Parse("2016-09-01")
                }
            };
            purchaseOrders.ForEach(po => context.PurchaseOrders.Add(po));
            context.SaveChanges();

            // Create some PO line items
            var lineItems = new List<LineItem>
            {
                new LineItem
                {
                    LineItemID = 2001,
                    PurchaseOrderID = 1001,
                    Name = "Laptop computer",
                    Quantity = 13,
                    UnitPrice = 1302.94
                },
                new LineItem
                {
                    LineItemID = 2002,
                    PurchaseOrderID = 1001,
                    Name = "LCD Monitor",
                    Quantity = 9,
                    UnitPrice = 201.45
                },
                new LineItem
                {
                    LineItemID = 2003,
                    PurchaseOrderID = 1001,
                    Name = "HDMI Cable",
                    Quantity = 9,
                    UnitPrice = 19.99
                },
                new LineItem
                {
                    LineItemID = 2004,
                    PurchaseOrderID = 1001,
                    Name = "PowerShell Script",
                    Quantity = 1,
                    UnitPrice = 1200.00
                },
                new LineItem
                {
                    LineItemID = 2005,
                    PurchaseOrderID = 1001,
                    Name = "Azure Resource Manager Template",
                    Quantity = 1,
                    UnitPrice = 549.00
                }
            };
            lineItems.ForEach(li => context.LineItems.Add(li));
            context.SaveChanges();
        }
    }
}