//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static root;

    public interface IFixedBits<F> : IBitField
        where F : unmanaged, IFixed
    {
        int IBitField.TotalWidth 
        {
            [MethodImpl(Inline)]
            get => bitsize<F>();
        }
    }

    public interface IFixedBits<W,F> : IFixedBits<F>
        where W : unmanaged, Enum
        where F : unmanaged, IFixed
    {

    }

    public interface IFixedBits<I,W,F> : IFixedBits<W,F>, IIndexedBits<I>
        where I : unmanaged, Enum
        where W : unmanaged, Enum
        where F : unmanaged, IFixed
    {
    
    }
}