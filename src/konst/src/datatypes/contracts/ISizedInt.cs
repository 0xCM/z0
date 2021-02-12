//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISizedInt : ITextual, IHashed
    {
        bool IsZero {get;}

        bool IsNonZero
            => !IsZero;
    }

    public interface ISizedInt<S> : ISizedInt, IEquatable<S>
        where S : unmanaged, ISizedInt<S>
    {

    }

    public interface ISizedInt<S,T> : ISizedInt<S>, INullary<S,T>, IDataType<T>
        where S : unmanaged, ISizedInt<S,T>
        where T : unmanaged
    {

    }

    public interface ISizedInt<S,W,T> : ISizedInt<S,T>
        where S : unmanaged, ISizedInt<S,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        BitWidth ISized.Width
            => default(W).BitWidth;
    }

    public interface ISizedInt<F,W,K,T> : ISizedInt<F,W,T>
        where F : unmanaged, ISizedInt<F,W,K,T>
        where W : unmanaged, IDataWidth
        where K : unmanaged, Enum
        where T : unmanaged
    {
        K Kind {get;}
    }
}