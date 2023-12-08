using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GdMAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GdMAPI.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<Material> TB_MATERIAL {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>().HasData
            (
                new Material() {Id = 1, Nome ="Lápis", Cor = "Preto", Marca = "FaberCastell", Tipo = Models.Enum.TipoEnum.Lapis, Quantidade = 1},
                new Material() {Id = 2, Nome = "Caneta", Cor = "Azul", Marca = "BIC", Tipo = Models.Enum.TipoEnum.Caneta, Quantidade = 1},
                new Material() {Id = 3, Nome = "Borracha", Cor = "Branco", Marca ="Mercur", Tipo = Models.Enum.TipoEnum.Borracha, Quantidade = 1},
                new Material() {Id = 4, Nome = "Apontador", Cor = "Transparente", Marca = "Cis", Tipo = Models.Enum.TipoEnum.Apontador, Quantidade = 1},
                new Material() {Id = 5, Nome = "Caderno", Cor = "Vermelho", Marca = "Spriral", Tipo = Models.Enum.TipoEnum.Caderno, Quantidade = 1},
                new Material() {Id = 6, Nome = "Livro", Cor = "Cinza", Marca = "SAE", Tipo = Models.Enum.TipoEnum.Livro, Quantidade = 1},
                new Material() {Id = 7, Nome = "Mochila", Cor = "Azul", Marca = "Kipling", Tipo = Models.Enum.TipoEnum.Mochila, Quantidade = 1},
                new Material() {Id = 8, Nome = "Estojo", Cor = "Cinza", Marca = "Genérica", Tipo = Models.Enum.TipoEnum.Estojo, Quantidade = 1}
            );

            
                
        }
    }










}
