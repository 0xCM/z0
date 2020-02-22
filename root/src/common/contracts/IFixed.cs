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
        int BitCount {get;}

        int FullByteCount
        {
            [MethodImpl(Inline)]
            get => BitCount / 8;
        }

        bool IsByteAligned
        {
            [MethodImpl(Inline)]
            get => BitCount % 8 == 0;
        }
    }

    /// <summary>
    ///  Characterizes a fixed type with storage and reification types of equal size
    /// </summary>
    /// <typeparam name="S">The storage type</typeparam>
    public interface IFixed<S> : IFixed
        where S : unmanaged
    {        
        int IFixed.FullByteCount 
        {
            [MethodImpl(Inline)]
            get => Unsafe.SizeOf<S>();
        }

        bool IFixed.IsByteAligned 
        {
            [MethodImpl(Inline)]
            get => true;
        }

        int IFixed.BitCount
        {
            [MethodImpl(Inline)]
            get => 8*FullByteCount;
        }
    }

    /// <summary>
    ///  Characterizes a fixed type where the storage and reification sizes may differ
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="S">The storage type</typeparam>
    public interface IFixed<F,S> : IFixed
        where F : unmanaged, IFixed<F,S>
        where S : unmanaged
    {

    }
}