﻿namespace Notino.Domain.Abstraction;

using Notino.Domain.Models.Abstraction;

public interface IDBOperations<TModel> 
    where TModel : IModel
{
    public Task<IEnumerable<TModel>> GetAsync(string query = null, object parameters = null);

    public Task<TModel> UpdateAsync(TModel data);
    
    public Task<TModel> InsertAsync(TModel data);
}
