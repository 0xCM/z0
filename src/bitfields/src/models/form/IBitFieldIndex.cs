//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitFieldIndex<E>
        where E : IBitFieldIndexEntry
    {
        ReadOnlySpan<E> Entries {get;}
    }
}