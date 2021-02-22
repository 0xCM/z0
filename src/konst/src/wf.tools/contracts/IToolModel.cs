//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdToolModel
    {
        Type ModelType {get;}
    }

    [Free]
    public interface ICmdToolModel<T> : ICmdToolModel
        where T : struct, ICmdToolModel<T>
    {
        Type ICmdToolModel.ModelType
            => typeof(T);
    }
}