//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Konst;
    using static z;

    [Free]
    public interface ITable<F,T,K> : ITable<F,T>
        where F : unmanaged
        where T : struct, ITable<F,T>
        where K : unmanaged
    {
        K Key {get;}
    }
    public interface ITableMap<T,Y> : IWfTableWorker
        where T : struct, ITable
    {
        Y Map(in T src);
    }

    public interface ITableMap<H,T,Y> : ITableMap<T,Y>
        where H : struct, ITableMap<H,T,Y>
        where T : struct, ITable
    {

    }

    /// <summary>
    /// Characterizes a D-discriminated table processor
    /// </summary>
    /// <typeparam name="D">The discriminator type</typeparam>
    /// <typeparam name="S">The discrimnator's scalar type</typeparam>
    /// <typeparam name="T">The data type</typeparam>
    /// <typeparam name="Y">The output type</typeparam>
    public interface ITableMap<D,S,T,Y> : ITableMap<T,Y>
        where D : unmanaged
        where T : struct, ITable
        where S : unmanaged
    {
        KeyMap<D,S> Id {get;}
    }

    /// <summary>
    /// Characterizes a reified D-discriminated table processor
    /// </summary>
    /// <typeparam name="H">The host type</typeparam>
    /// <typeparam name="D">The discriminator type</typeparam>
    /// <typeparam name="S">The discrimnator's scalar type</typeparam>
    /// <typeparam name="T">The data type</typeparam>
    /// <typeparam name="Y">The output type</typeparam>
    public interface ITableMap<H,D,S,T,Y> : ITableMap<D,S,T,Y>
        where H : struct, ITableMap<H,D,S,T,Y>
        where D : unmanaged
        where T : struct, ITable
        where S : unmanaged
    {

    }
}