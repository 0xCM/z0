//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISized
    {
        /// <summary>
        /// Specifies the bit-scaled data width of the reification type
        /// </summary>
        uint Width {get;}

        uint Size
            => Width/8;
    }

    public interface ISized<W> : ISized
        where W : unmanaged, IDataWidth
    {
        new W Width => default(W);

        uint ISized.Width
            => Width.Value;
    }

    public interface ISized<F,W> : ISized<W>
        where F : unmanaged, ISized<F,W>
        where W : unmanaged, IDataWidth
    {

    }

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

    public interface ISizedInt<S,T> : ISizedInt<S>, INullary<S,T>
        where S : unmanaged, ISizedInt<S,T>
        where T : unmanaged
    {
        T Value {get;}
    }

    public interface ISizedInt<S,W,T> : ISizedInt<S,T>
        where S : unmanaged, ISizedInt<S,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

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