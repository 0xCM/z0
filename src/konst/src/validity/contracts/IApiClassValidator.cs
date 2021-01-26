//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IApiClassValidator : IApiValidator
    {
        ApiClass Class {get;}
    }

    public interface IApiClassValidator<K> : IApiClassValidator
        where K : unmanaged
    {
        new ApiClass<K> Class {get;}

        ApiClass IApiClassValidator.Class
            => Class;
    }
}