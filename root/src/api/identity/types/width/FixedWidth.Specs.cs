//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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
    ///  Characterizes a fixed type with storage and reification types of equal size
    /// </summary>
    /// <typeparam name="F">The storage type</typeparam>
    public interface IFixed<F> : IFixed
        where F : unmanaged
    {
        // FixedWidth IFixedWidth.FixedWidth
        // {
        //     [MethodImpl(Inline)]
        //     get => (FixedWidth)bitsize<F>();
        // }

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
}