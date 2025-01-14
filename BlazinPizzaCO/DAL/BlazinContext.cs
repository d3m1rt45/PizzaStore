﻿using BlazinPizzaCO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BlazinPizzaCO.DAL
{
    public class BlazinContext : DbContext
    {
        public BlazinContext() : base("name=BlazinContext")
        {
            Database.SetInitializer(new BlazinContextInitializer());
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Side> Sides { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<DrinkPerOrder> DrinksPerOrder { get; set; }
        public DbSet<SidePerOrder> SidesPerOrder { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}