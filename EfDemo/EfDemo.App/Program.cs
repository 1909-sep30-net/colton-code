﻿using System;
using System.Linq;
using EfDemo.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EfDemo.App
{
    class Program
    {
        // Entity Framework Core
        // database-first approach steps...
        /*
         * 1. have a data access library project separate from the startup application project.
         *    (with a project reference from the latter to the former).
         * 2. install Microsoft.EntityFrameworkCore.Design and Microsoft.EntityFrameworkCore.SqlServer
         *    to both projects.
         * 3. using Git Bash / terminal, from the data access project folder run (split into several lines for clarity):
         *    dotnet ef dbcontext scaffold <connection-string-in-quotes>
         *      Microsoft.EntityFrameworkCore.SqlServer
         *      --startup-project <path-to-startup-project-folder>
         *      --force
         *      --output-dir Entities
         *    https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet#dotnet-ef-dbcontext-scaffold
         *    (if you don't have dotnet ef installed, run: "dotnet tool install --global dotnet-ef")
         *    (this will fail if your projects do not compile)
         * 4. delete the DbContext.OnConfiguring method from the scaffolded code.
         *    (so that the connection string is not put on the public internet)
         * 5. any time you change the structure of the tables (DDL), go to step 3.
         */



        // Entity Framework configures itself at runtime
        // from three sources -
        // (1) OnModelConfiguring method (fluent API)
        // (2) DataAnnotations attributes on the entity classes
        // (3) conventions
        //      - e.g.: if a type named "X" has a property named either "Id" or "XId",
        //            it will be assumed to be the primary key

        public static readonly ILoggerFactory AppLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        static void Main(string[] args)
        {
            string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<PokemonDbContext> options = new DbContextOptionsBuilder<PokemonDbContext>()
                .UseSqlServer(connectionString)
                .UseLoggerFactory(AppLoggerFactory)
                .Options;

            using var context = new PokemonDbContext(options);

            DisplayPokemon(context);
            AddNewPokemon(context);
            EditAPokemon(context);
            DeleteAPokemon(context);
        }

        static void DisplayPokemon(PokemonDbContext context)
        {
            foreach (Pokemon pokemon in context.Pokemon
                .Include(p => p.PokemonType)
                    .ThenInclude(pt => pt.Type))
            {
                string types = string.Join(", ", pokemon.PokemonType.Select(pt => pt.Type.Name));
                if (types.Length == 0)
                {
                    types = "[none]";
                }
                Console.WriteLine($"Pokemon {pokemon.Name} (type {types})");
            }
        }

        static void AddNewPokemon(PokemonDbContext context)
        {
            using (var db = new PokemonDbContext())
            {
                

                db.Add(new Pokemon { "Coltron" });
                db.SaveChanges();
            }
        }

        static void EditAPokemon(PokemonDbContext context)
        {

        }

        static void DeleteAPokemon(PokemonDbContext context)
        {

        }
    }
}
