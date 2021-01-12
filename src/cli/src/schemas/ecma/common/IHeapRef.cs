//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IHeapRef
    {
        Token Id {get;}
    }

    public interface IHeapRef<T> : IHeapRef
        where T : unmanaged, IHeapRef<T>
    {

    }
}