//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IArrow : ILink
    {

    }

    [Free]
    public interface IArrow<S,T> : IArrow, ILink<S,T>
    {
        string IIdentified.Identifier
            => string.Format("{0} -> {1}", Source, Target);
    }

    [Free]
    public interface ILink<T> : IArrow<T,T>
    {

    }

    [Free]
    public interface IArrows<T> : IArrow<T,T[]>
    {
        T[] Targets {get;}
    }

    [Free]
    public interface IArrows<S,T> : IArrow<S,T[]>
    {
        T[] Targets {get;}
    }

    [Free]
    public interface ILink<F,S,T> : IArrow<S,T>
        where F : ILink<F,S,T>
    {

    }

    [Free]
    public interface IKindedArrow<K> : IArrow, IKinded<K>
        where K : unmanaged
    {

    }

    [Free]
    public interface IKindedArrow<K,S,T> : IKindedArrow<K>, IArrow<S,T>
        where K : unmanaged
    {

    }
}