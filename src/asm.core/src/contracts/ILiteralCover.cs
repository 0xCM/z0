//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ILiteralCover
    {

    }

    public interface  ILiteralCover<T> : ILiteralCover
        where T : unmanaged
    {
        T Literal {get;}
    }

    public interface ILiteralCover<C,T> : ILiteralCover<T>
        where C : unmanaged, ILiteralCover<C,T>
        where T : unmanaged
    {

    }
}