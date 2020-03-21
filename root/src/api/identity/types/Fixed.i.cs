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
        int FixedBitCount {get;}

        int FixedByteCount
        {
            [MethodImpl(Inline)]
            get => FixedBitCount / 8;
        }

        bool IsByteAligned
        {
            [MethodImpl(Inline)]
            get => FixedBitCount % 8 == 0;
        }
    }

    public interface IFixedWidth : IFixed
    {
        /// <summary>
        /// Specifies the type width in bits
        /// </summary>
        FixedWidth FixedWidth {get;}

        int IFixed.FixedBitCount
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
        int IFixed.FixedByteCount 
        {
            [MethodImpl(Inline)]
            get => Unsafe.SizeOf<F>();
        }

        bool IFixed.IsByteAligned 
        {
            [MethodImpl(Inline)]
            get => true;
        }

        int IFixed.FixedBitCount
        {
            [MethodImpl(Inline)]
            get => 8*FixedByteCount;
        }
    }

    /// <summary>
    /// Characterizes a kind with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedKind : IKind
    {
        int BitWidth {get;}
    }

    /// <summary>
    /// Characterizes a reified kind with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedKind<F> : IFixedKind
        where F : unmanaged, IFixed
    {
        int IFixedKind.BitWidth
        {
            [MethodImpl(Inline)]
            get => bitsize<F>();
        }
    }
}