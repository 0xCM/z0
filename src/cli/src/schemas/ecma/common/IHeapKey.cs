//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IHeapKey
    {
        HeapKind HeapKind {get;}

        uint Value {get;}
    }

    public interface IHeapKey<K> : IHeapKey
        where K : struct, IHeapKey<K>
    {

    }
}