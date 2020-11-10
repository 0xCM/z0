//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITableProjector
    {

    }

    [Free]
    public interface ITableProjector<T,Y> : ITableProjector
        where T : struct
    {
        Y Project(in T src);
    }

    [Free]
    public interface ITableProjector<H,T,Y> : ITableProjector<T,Y>
        where H : struct, ITableProjector<H,T,Y>
        where T : struct
    {

    }

    /// <summary>
    /// Characterizes a D-discriminated table processor
    /// </summary>
    /// <typeparam name="D">The discriminator type</typeparam>
    /// <typeparam name="S">The discrimnator's scalar type</typeparam>
    /// <typeparam name="T">The data type</typeparam>
    /// <typeparam name="Y">The output type</typeparam>
    [Free]
    public interface ITableProjector<D,S,T,Y> : ITableProjector<T,Y>
        where D : unmanaged
        where T : struct
        where S : unmanaged
    {
        KeyedIndex<D,S> Id {get;}
    }

    /// <summary>
    /// Characterizes a reified D-discriminated table processor
    /// </summary>
    /// <typeparam name="H">The host type</typeparam>
    /// <typeparam name="D">The discriminator type</typeparam>
    /// <typeparam name="S">The discrimnator's scalar type</typeparam>
    /// <typeparam name="T">The data type</typeparam>
    /// <typeparam name="Y">The output type</typeparam>
    [Free]
    public interface ITableProjector<H,D,S,T,Y> : ITableProjector<D,S,T,Y>
        where H : struct, ITableProjector<H,D,S,T,Y>
        where D : unmanaged
        where T : struct
        where S : unmanaged
    {

    }
}