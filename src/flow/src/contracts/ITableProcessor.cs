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

    public interface ITableProcessor<T,Y>
        where T : struct, ITable
    {
        Y Process(in T src);
    }

    public interface ITableProcessor<H,T,Y> : ITableProcessor<T,Y>
        where H : struct, ITableProcessor<H,T,Y>
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
    public interface ITableProcessor<D,S,T,Y>
        where D : unmanaged, Enum
        where T : struct, ITable
        where S : unmanaged
    {
        Selector<D,S> Id {get;}

        Y Process(in T x); 
    }

    /// <summary>
    /// Characterizes a reified D-discriminated table processor
    /// </summary>
    /// <typeparam name="H">The host type</typeparam>
    /// <typeparam name="D">The discriminator type</typeparam>
    /// <typeparam name="S">The discrimnator's scalar type</typeparam>
    /// <typeparam name="T">The data type</typeparam>
    /// <typeparam name="Y">The output type</typeparam>
    public interface ITableProcessor<H,D,S,T,Y> : ITableProcessor<D,S,T,Y>
        where H : struct, ITableProcessor<H,D,S,T,Y>
        where D : unmanaged, Enum
        where T : struct, ITable
        where S : unmanaged
    {
        
    }    
}