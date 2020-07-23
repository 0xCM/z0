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

    public interface IArrow<F,T> : IArrow<T>
        where F : unmanaged, IArrow<F,T>
    {

    }

    public interface IPath<T>
    {
        T[]  Nodes {get;}
    }
}