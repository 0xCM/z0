//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IArrow : IIdentified
    {
        object Src {get;}   

        object Dst {get;}
    }

    public interface IArrow<A,S,T> : IArrow, IIdentifiedTarget<A>
        where S : IIdentifiedTarget<S>, new()
        where T : IIdentifiedTarget<T>, new()
        where A : IArrow<A,S,T>, new()
    {
        new S Src {get;}

        new T Dst {get;}

        object IArrow.Src
            => Src;

        object IArrow.Dst
            => Dst;
    }


    public interface IPath
    {
        object[] Nodes {get;}
    }

    public interface IPath<A> : IPath
        where A : IEquatable<A>
    {
        new A[]  Nodes {get;}

        object[] IPath.Nodes
            => Nodes.Map(x => (object)x);
    }

    public interface IMixedPath<A,B> : IPath
    {
        A Src {get;}

        B Dst {get;}

        object[] IPath.Nodes
            => new object[]{Src,Dst};
    }

    public interface IMixedPath<A,B,C> : IMixedPath<A,B>
    {
        
        C c {get;}

        object[] IPath.Nodes
            => new object[]{Src,Dst,c};

    }

    public interface IPath<A,B,C,D> : IMixedPath<A,B,C>
    {
        D d {get;}

        object[] IPath.Nodes
            => new object[]{Src,Dst,c,c};
    }
}