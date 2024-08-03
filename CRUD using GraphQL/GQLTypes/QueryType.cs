using CRUD_using_GraphQL.Data;
using CRUD_using_GraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_using_GraphQL.GQLTypes
{
    public class QueryType
    {
        public async Task<List<Cake>> AllCakeAsync([Service] MyWorldDbContext context)
        {
            return await context.Cake.ToListAsync();
        }
    }
}
