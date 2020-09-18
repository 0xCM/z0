//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IArrow : ILink
    {

    }

    [Free]
    public interface IArrow<S,T> : IArrow, ILink<S,T>
    {
        S Source {get;}

        T Target {get;}

        S ILink<S,T>.A
            => Source;

        T ILink<S,T>.B
            => Target;

        string IIdentified.Identifier
            => string.Format("{0} -> {1}", Source, Target);
    }

    [Free]
    public interface IArrow<T> : IArrow<T,T>
    {


    }

    [Free]
    public interface IArrows<T> : IArrow<T,T[]>
    {
        T[] Targets {get;}

        T[] IArrow<T,T[]>.Target
            => Targets;
    }

    [Free]
    public interface IArrows<S,T> : IArrow<S,T[]>
    {
        T[] Targets {get;}

        T[] IArrow<S,T[]>.Target
            => Targets;
    }

    [Free]
    public interface IArrow<F,S,T> : IArrow<S,T>
        where F : IArrow<F,S,T>
    {

    }

    [Free]
    public interface IPath<T>
    {
        T[]  Nodes {get;}
    }
}