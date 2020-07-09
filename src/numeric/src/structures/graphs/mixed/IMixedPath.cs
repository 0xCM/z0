//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMixedPath
    {
        object[] Nodes {get;}
    }
    
    public interface IMixedArrow<A,S,T> : IIdentification<A>
        where S : IIdentification<S>, new()
        where T : IIdentification<T>, new()
        where A : IMixedArrow<A,S,T>, new()
    {
        S Src {get;}

        T Dst {get;}
    }

    /// <summary>
    /// Characterizes a path between heterogeneous nodes
    /// </summary>
    /// <typeparam name="A">The source node type</typeparam>
    /// <typeparam name="B">The target node type</typeparam>
    public interface IMixedPath<A,B> : IMixedPath
    {
        A Src {get;}

        B Dst {get;}

        object[] IMixedPath.Nodes
            => new object[]{Src,Dst};
    }

    public interface IMixedPath<A,B,C> : IMixedPath<A,B>
    {        
        C c {get;}

        object[] IMixedPath.Nodes
            => new object[]{Src,Dst,c};
    }

    public interface IMixedPath<A,B,C,D> : IMixedPath<A,B,C>
    {
        D d {get;}

        object[] IMixedPath.Nodes
            => new object[]{Src,Dst,c,c};
    }
}