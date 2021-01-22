//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XTend
    {
        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static Bit32 TestC<T>(this BitVector<T> src)
            where T : unmanaged
                => BitVector.testc(src);

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static Bit32 TestC<N,T>(this BitVector<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.testc(src);

        [MethodImpl(Inline)]
        public static Bit32 TestC<N,T>(this BitVector128<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.testc(src);

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static Bit32 TestC(this BitVector8 src)
            => BitVector.testc(src);

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static Bit32 TestC(this BitVector16 src)
            => BitVector.testc(src);

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static Bit32 TestC(this BitVector32 src)
            => BitVector.testc(src);

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static Bit32 TestC(this BitVector64 src)
            => BitVector.testc(src);
    }
}