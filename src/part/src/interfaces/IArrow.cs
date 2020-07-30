//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IArrow : IIdentified
    {

    }

    public interface IArrow<T> : IArrow
    {
        T Src {get;}

        T Dst {get;}
    }

    public interface IArrow<S,T> : IArrow
    {
        S Src {get;}

        T Dst {get;}
    }
    
    public interface IArrow<F,S,T> : IArrow<S,T>
        where F : IArrow<F,S,T>
    {

    }

    public interface IPath<T>
    {
        T[]  Nodes {get;}
    }
}