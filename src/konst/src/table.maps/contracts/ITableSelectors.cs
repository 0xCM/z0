//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface ITableSelectors<K,I>
        where K : unmanaged
        where I : unmanaged
    {
        I MinIndex {get;}

        I MaxIndex {get;}

        I[] IndexEntries {get;}

        ClosedInterval<ulong> Positions {get;}

        ClosedInterval<ulong> Indices {get;}

        ulong Offset {get;}

        ref KeyMap<K,I> this[K id] {get;}

        ref KeyMap<K,I> this[I index] {get;}

        ref KeyMap<K,I> this[ulong index] {get;}
    }

    public interface IKeyMapIndex<H,D,S> : ITableSelectors<D,S>
        where D : unmanaged
        where S : unmanaged
        where H : struct, IKeyMapIndex<H,D,S>
    {

    }
}