//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    /// <summary>
    /// Characterizes a type that occupies a fixed amount of space at runtime
    /// </summary>
    public interface IFixed
    {
        /// <summary>
        /// The invariant number of bits covered by the reifying type
        /// </summary>
        int BitWidth {get;}

        int ByteCount
        {
            [MethodImpl(Inline)]
            get => BitWidth / 8;
        }
    }

    public interface IFixedWidth : IFixed
    {
        /// <summary>
        /// Specifies the type width in bits
        /// </summary>
        FixedWidth FixedWidth {get;}

        int IFixed.BitWidth
        {
            [MethodImpl(Inline)]
            get => (int)FixedWidth;
        }        
    }

    /// <summary>
    /// Characterizes a type that is naturally-parametric with natural widths that can be specified as a fixed-width
    /// </summary>
    /// <typeparam name="W">The natural width type</typeparam>
    public interface IFixedWidth<W> : IFixedWidth
        where W : unmanaged, ITypeWidth
    {
        FixedWidth IFixedWidth.FixedWidth
        {
            [MethodImpl(Inline)]
            get => default(W).FixedWidth;
        }
    }

    /// <summary>
    ///  Characterizes a fixed type with storage and reification types of equal size
    /// </summary>
    /// <typeparam name="F">The storage type</typeparam>
    public interface IFixed<F> : IFixed
        where F : unmanaged
    {
        int IFixed.ByteCount 
        {
            [MethodImpl(Inline)]
            get => Unsafe.SizeOf<F>();
        }

        int IFixed.BitWidth
        {
            [MethodImpl(Inline)]
            get => (int)bitsize<F>();
        }        
    }

    /// <summary>
    /// Characterizes a reified kind with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedKind<F> : IFixed<F>,  IKind
        where F : unmanaged, IFixed
    {
        int IFixed.BitWidth
        {
            [MethodImpl(Inline)]
            get => (int)bitsize<F>();
        }                
    }

}