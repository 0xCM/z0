//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolModel
    {
        Type ModelType {get;}
    }

    [Free]
    public interface IToolModel<T> : IToolModel
        where T : struct, IToolModel<T>
    {
        Type IToolModel.ModelType
            => typeof(T);
    }
}