//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IHeapRef<T>
        where T : unmanaged, IHeapRef<T>
    {
        Token Id {get;}
    }
}