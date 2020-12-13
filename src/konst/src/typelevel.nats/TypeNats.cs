//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    using static z;

    public partial class TypeNats
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static NatSpan<N,T> span<N,T>(T[] src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatSpan.load(src,n);

        [MethodImpl(Inline)]
        public static NatSpan<N,T> span<N,T>(Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatSpan.load(src,n);

        /// <summary>
        /// Defines a digit relative to a natural base
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The digit's enumeration type</typeparam>
        /// <typeparam name="N">The natural base type</typeparam>
        [MethodImpl(Inline)]
        public static Digit<N,T> digit<N,T>(T src, N @base = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Digit<N,T>(src);

        /// <summary>
        /// Constructs a natural representative for a specified parametric type
        /// </summary>
        /// <typeparam name="K">The representative type to construct</typeparam>
        [MethodImpl(Inline)]
        public static K nat<K>(K k = default)
            where K : unmanaged, ITypeNat
                => default;

        /// <summary>
        /// Constructs the natural type corresponding to an integral value
        /// </summary>
        /// <param name="digits">The source digits</param>
        [MethodImpl(Inline)]
        public static INatSeq reflect(ulong value)
            => seq(digits(value));

        [MethodImpl(Inline)]
        internal static int bitsize<T>()
            => Unsafe.SizeOf<T>()*8;


        /// <summary>
        /// Adds a an offset of 1 byte to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T offset<T>(in T src, N1 n)
            => ref AddByteOffset(ref edit(src), (IntPtr)1);

        /// <summary>
        /// Adds a an offset of 2 bytes to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T offset<T>(in T src, N2 n)
            => ref AddByteOffset(ref edit(src), (IntPtr)2);

        /// <summary>
        /// Adds a an offset of 3 bytes to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T offset<T>(in T src, N3 n)
            => ref AddByteOffset(ref edit(src), (IntPtr)3);

        /// <summary>
        /// Adds a an offset of 4 bytes to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T offset<T>(in T src, N4 n)
            => ref AddByteOffset(ref edit(src), (IntPtr)4);

        /// <summary>
        /// Adds a an offset of 5 bytes to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T offset<T>(in T src, N5 n)
            => ref AddByteOffset(ref edit(src), (IntPtr)5);

        /// <summary>
        /// Adds a an offset of 6 bytes to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T offset<T>(in T src, N6 n)
            => ref AddByteOffset(ref edit(src), (IntPtr)6);

        /// <summary>
        /// Adds a an offset of 7 bytes to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T offset<T>(in T src, N7 n)
            => ref AddByteOffset(ref edit(src), (IntPtr)7);
    }
}