//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes a type that is naturally-parametric with natural widths that can be specified as a fixed-width
    /// </summary>
    /// <typeparam name="W">The natural width type</typeparam>
    public interface IFixedWidth<W> : IFixedWidth
        where W : unmanaged, ITypeNat
    {
        FixedWidth IFixedWidth.FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)nateval<W>();
        }
    }

    public interface IFixed<F,W> : IFixedWidth, IFixed<F>
        where F : unmanaged, IFixed
        where W : unmanaged, ITypeNat
    {

        int IFixed.BitCount 
        {
            [MethodImpl(Inline)]
            get => bitsize<F>();
        }
                    
    } 
}