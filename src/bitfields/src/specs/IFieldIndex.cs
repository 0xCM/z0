//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public interface IFieldIndex<E>
        where E : IFieldIndexEntry
    {
        ReadOnlySpan<E> Entries {get;}
    }
}