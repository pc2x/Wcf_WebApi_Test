using AutoMapper;
using pc2x.Application.Core.RepositoriesContracts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace pc2x.Application.Repositories.Repositories
{
    public abstract class GenericRepository<TSource, TTarget, TContext> : IGenericRepository<TTarget>
        where TSource : class
        where TTarget : class
        where TContext : DbContext, new()
    {

        public async Task<TTarget> Add(TTarget model)
        {
            using (var ctx = new TContext())
            {
                //var mapper = new MapperConfiguration(c =>
                //    c.CreateMap<TTarget, TSource>());

                //var m = mapper.CreateMapper();

                //mapea a entidad de EF
                var entity = Mapper.Map<TSource>(model);

                //agrega la entidad al contexto
                ctx.Set<TSource>().Add(entity);

                //se guardan cambios
                await ctx.SaveChangesAsync();

                //retorna el modelo
                return Mapper.Map<TTarget>(entity);
            }
            //return (TTarget)Activator.CreateInstance(typeof(TTarget));
        }

        public IEnumerable<TTarget> GetAll()
        {
            using (var ctx = new TContext())
            {
                return ctx.Set<TSource>().Select(Mapper.Map<TTarget>).ToList();
            }
        }

        public async Task Edit(TTarget model)
        {
            using (var ctx = new TContext())
            {
                //adjunta la entidad al contexto y la pone en estado modificado
                ctx.Entry(model).State = EntityState.Modified;

                //se guardan los cambios
                await ctx.SaveChangesAsync();
            }
        }

        public async Task Delete(TTarget model)
        {
            using (var ctx = new TContext())
            {
                //mapea a entidad de EF
                var entity = Mapper.Map<TSource>(model);

                //se remueve del contexto
                ctx.Set<TSource>().Remove(entity);

                //se guardan los cambios
                await ctx.SaveChangesAsync();
            }
        }
    }
}