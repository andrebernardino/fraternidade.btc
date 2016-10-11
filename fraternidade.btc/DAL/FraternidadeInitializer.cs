using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using fraternidade.btc.Models;

namespace fraternidade.btc.DAL
{
    public class FraternidadeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<fraternidadeDBContext>
    {
        protected override void Seed(fraternidadeDBContext context)
        {
            var usuarios = new List<Usuario>
            {

                new Usuario  {IDUsuario=1, Nome="André Bernardino", Email="andre@cdis.com.br",Senha="sdjlfsdfjlk",DataCadastro=DateTime.Now,DataAtivacao=DateTime.Now },
                new Usuario  {IDUsuario=2, Nome="Carlos Alberto Silva", Email="carlosalberto@cdis.com.br",Senha="sdjlfsdfjlk",DataCadastro=DateTime.Now,DataAtivacao=DateTime.Now },
                new Usuario  {IDUsuario=3, Nome="Janaina santos Parreira", Email="janainasantos@cdis.com.br",Senha="sdjlfsdfjlk",DataCadastro=DateTime.Now,DataAtivacao=DateTime.Now },
                new Usuario  {IDUsuario=4, Nome="Joarez Carlos Damasceno", Email="joarez@cdis.com.br",Senha="sdjlfsdfjlk",DataCadastro=DateTime.Now,DataAtivacao=DateTime.Now },
                new Usuario  {IDUsuario=5, Nome="Carla Patrícia Moreira", Email="carlapatricia@cdis.com.br",Senha="sdjlfsdfjlk",DataCadastro=DateTime.Now,DataAtivacao=DateTime.Now },
                new Usuario  {IDUsuario=6, Nome="Carlos Mariano Silva", Email="carlosmariano@cdis.com.br",Senha="sdjlfsdfjlk",DataCadastro=DateTime.Now,DataAtivacao=DateTime.Now },
                new Usuario  {IDUsuario=7, Nome="Andressa Bernardino Cardoso", Email="andressacardoso@cdis.com.br",Senha="sdjlfsdfjlk",DataCadastro=DateTime.Now,DataAtivacao=DateTime.Now },
                new Usuario  {IDUsuario=8, Nome="Juliana Batista de Queiroz", Email="julianabatista@cdis.com.br",Senha="sdjlfsdfjlk",DataCadastro=DateTime.Now,DataAtivacao=DateTime.Now }
            };

            usuarios.ForEach(u => context.Usuarios.Add(u));
            context.SaveChanges();

            var enderecosBitcoin = new List<EnderecoBitcoin>
            {
            new EnderecoBitcoin {endereco="erowrw4ewkoklfksldkfsa",Usuario=usuarios[0] },
            new EnderecoBitcoin {endereco="erowrw4ewkoklfksldkfsb",Usuario=usuarios[1] },
            new EnderecoBitcoin {endereco="erowrw4ewkoklfksldkfsc",Usuario=usuarios[2] },
            new EnderecoBitcoin {endereco="erowrw4ewkoklfksldkfsd",Usuario=usuarios[3] },
            new EnderecoBitcoin {endereco="erowrw4ewkoklfksldkfse",Usuario=usuarios[4] },
            new EnderecoBitcoin {endereco="erowrw4ewkoklfksldkfsf",Usuario=usuarios[5] },
            new EnderecoBitcoin {endereco="erowrw4ewkoklfksldkfsg",Usuario=usuarios[6] },
            new EnderecoBitcoin {endereco="erowrw4ewkoklfksldkfhl",Usuario=usuarios[7] }
            };


            enderecosBitcoin.ForEach(s => context.EnderecosBitcoin.Add(s));
            context.SaveChanges();

        }
    }
}