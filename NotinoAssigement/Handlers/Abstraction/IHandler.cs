﻿namespace NotinoAssigement.Handlers.Abstraction;

internal interface IHandler<TModel>
{
    public Task<TModel> HandleAsync(TModel model);

}