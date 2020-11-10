//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ILink : ITextual, IIdentified
    {
        string ITextual.Format()
            => Identifier;
    }

    /// <summary>
    /// Characterizes an association between two parties of heterogenous type
    /// </summary>
    /// <typeparam name="S">The first party type</typeparam>
    /// <typeparam name="T">The second party type</typeparam>
    [Free]
    public interface ILink<S,T> : ILink
    {
        S Source {get;}

        T Target {get;}
    }

    [Free]
    public interface ILink<T> : ILink<T,T>
    {

    }

    [Free]
    public interface ILink<F,S,T> : ILink<S,T>
        where F : ILink<F,S,T>
    {

    }

    [Free]
    public interface IKindedLink<K> : ILink, IKinded<K>
        where K : unmanaged
    {

    }

    [Free]
    public interface IKindedLink<K,S,T> : IKindedLink<K>, ILink<S,T>
        where K : unmanaged
    {

    }
}