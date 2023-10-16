using Lab17Extry.ShopResources;
using Lab17Extry.Shop.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab17Extry.Shop
{
    static class Shop
    {
        public static Category AddCategory(string name, string img)
        {
            using var ctx = new ShopDBContext();
            var category = new Category
            {
                Name = name,
                Img = img

            };
            ctx.Categories.Add(category) ;
            ctx.SaveChanges();
            return category ;
        }

        public static Manufacturer AddManufacturer(string name, string address,int cUI) 
        {
            using var ctx = new ShopDBContext();
            var manufacturer = new Manufacturer
            {
                Name = name,
                Address = address,
                CUI = cUI
            };
            ctx.Manufacturers.Add(manufacturer) ;
            ctx.SaveChanges();
            return manufacturer ;
        }

        public static Product AddProduct(string name,int stoc,int manufacturerId,int categoryId,double price)
        {
            using var ctx = new ShopDBContext();
            if (!ctx.Categories.Any(c=>c.Id ==categoryId))
            {
                throw new InvalidCategoryIdException($"The id {categoryId} does not exist in Categories");
            }
            if (!ctx.Manufacturers.Any(m => m.Id == categoryId))
            {
                throw new InvalidManufacturerIdException($"The id {manufacturerId} does not exist in Categories");
            }
            var product = new Product
            {
                Name = name,
                Stoc = stoc,
                ManufacturerId = manufacturerId,
                CategoryId = categoryId,
                Label = new Label()
                {
                    Price = price,


                }

            };
            ctx.Products.Add(product);
            ctx.SaveChanges();
            return product;
        }

        public static void ChangeProductPrice( int productId, double newPrice)
        {
            using var ctx = new ShopDBContext();
            var product = ctx.Products.FirstOrDefault(p=>p.Equals(productId));
            product.Label.Price = newPrice;
            ctx.SaveChanges();
        }

        public static double GetTotaValue() 
        {
            using var ctx = new ShopDBContext();

            double totalValue = ctx.Products.Sum(p => p.Label.Price*p.Stoc);
            return totalValue;
        }

       

        public static double GetTotaValue(Category category)
        {
            using var ctx = new ShopDBContext();
            if (!ctx.Categories.Any(c => c.Id == category.Id))
            {
                throw new InvalidCategoryIdException($"The id {category.Id} does not exist in Categories");
            }
            var x = ctx.Products
                
                .Where(c => c.CategoryId == category.Id).Sum(p => p.Label.Price*p.Stoc);
                
            
            return x;
        }

        public static double GetTotaValue(Manufacturer manufacturer)
        {
            using var ctx = new ShopDBContext();
            if (!ctx.Manufacturers.Any(m => m.Id == manufacturer.Id))
            {
                throw new InvalidManufacturerIdException($"The id {manufacturer.Id} does not exist in Categories");
            }
            double totalManufacturedValue = ctx.Products
               
                .Where(p=>p.ManufacturerId==manufacturer.Id)
                .Sum(p => p.Label.Price* p.Stoc);   
            
            return totalManufacturedValue;
        }
    }
}
