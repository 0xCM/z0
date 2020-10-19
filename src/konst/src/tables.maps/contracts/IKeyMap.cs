//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a bijective correspondence between keys and indexes
    /// </summary>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="I">The index type</typeparam>
    [Free]
    public interface IKeyMap<K,I>
        where K : unmanaged
        where I : unmanaged
    {
        I MinIndex {get;}

        I MaxIndex {get;}

        I[] IndexEntries {get;}

        ClosedInterval<ulong> Positions {get;}

        ClosedInterval<ulong> Indices {get;}

        ulong Offset {get;}

        ref KeyedIndex<K,I> this[K id] {get;}

        ref KeyedIndex<K,I> this[I index] {get;}

        ref KeyedIndex<K,I> this[ulong index] {get;}
    }

    /// <summary>
    /// Characterizes a <see cref='IKeyMap{D,S}'/> reification
    /// </summary>
    /// <typeparam name="H">The host type</typeparam>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="I"></typeparam>
    [Free]
    public interface IKeyMap<H,K,I> : IKeyMap<K,I>
        where K : unmanaged
        where I : unmanaged
        where H : struct, IKeyMap<H,K,I>
    {

    }
}