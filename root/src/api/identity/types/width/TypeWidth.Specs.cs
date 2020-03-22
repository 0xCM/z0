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
    public interface IFixed<F> : IFixedWidth
        where F : unmanaged
    {        
        FixedWidth IFixedWidth.FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)bitsize<F>();
        }

        int IFixed.FixedByteCount 
        {
            [MethodImpl(Inline)]
            get => Unsafe.SizeOf<F>();
        }

        int IFixed.FixedBitCount
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
    }

    public interface ITypeWidth : ILiteralKind<TypeWidthKind>, IFixedWidth
    {
        FixedWidth IFixedWidth.FixedWidth => (FixedWidth)Class;
    }

    public interface ITypeWidth<K> : ITypeWidth
        where K : struct, ITypeWidth<K>
    {
    
    }

    public readonly struct TypeWidth<T> : ITypeWidth<TypeWidth<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator TypeWidthKind(TypeWidth<T> src)
            => src.Class;

        public TypeWidthKind Class 
        {
            [MethodImpl(Inline)]
            get => (TypeWidthKind)(Unsafe.SizeOf<T>() *8);            
        }
    }
}