//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
        
    using static Root;

    [ApiHost(ApiHostKind.Generic)]
    public static class Refs
    {
        [MethodImpl(Inline)]
        static IntPtr intptr(long i)
            => new IntPtr(i);

        [MethodImpl(Inline)]
        public static ref T cast<S,T>(ref S src)
            => ref Unsafe.As<S,T>(ref src);

        /// <summary>
        /// Reinterprents a source value through the perpective of another type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cast<S,T>(ref S src, out T dst)
        {
            dst = Unsafe.As<S,T>(ref src);
            return ref dst;
        }

        /// <summary>
        /// Presents a readonly reference as reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T mutable<T>(in T src)
            => ref Unsafe.AsRef(in src);

        /// <summary>
        /// Presents a reference as a byte reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref byte byterefR<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

        /// <summary>
        /// Presents a readonly reference as a byte reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref byte byteref<T>(in T src)
            => ref Unsafe.As<T,byte>(ref mutable(in src));

        /// <summary>
        /// The canonical swap function
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static void swap<T>(ref T lhs, ref T rhs)
        {
            var temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        /// <summary>
        /// Adds an offset to a reference, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T seek<T>(ref T src, int count)
            => ref Unsafe.Add(ref src, count);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref byte seek8<T>(ref T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref src), count);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ushort seek16<T>(ref T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ushort>(ref src), count);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref uint seek32<T>(ref T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,uint>(ref src), count);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ulong seek64<T>(ref T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ulong>(ref src), count);

        /// <summary>
        /// Adds an offset to a reference, measured in bytes
        /// </summary>
        /// <param name="src">The soruce reference</param>
        /// <param name="count">The number of bytes to add</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T seekb<T>(ref T src, long count)
            => ref Unsafe.AddByteOffset(ref src, intptr(count));

        /// <summary>
        /// Skips a specified number of source elements and returns a readonly reference to the resulting element
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly T skip<T>(in T src, int count)
            => ref Unsafe.Add(ref mutable(in src), count);

        /// <summary>
        /// Skips a specified number of 8-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref byte skip8<T>(in T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref mutable(in src)), count);

        /// <summary>
        /// Skips a specified number of 16-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 16-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ushort skip16<T>(in T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ushort>(ref mutable(in src)), count);

        /// <summary>
        /// Skips a specified number of 32-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref uint skip32<T>(in T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,uint>(ref mutable(in src)), count);

        /// <summary>
        /// Skips a specified number of 64-bit source segments and returns a readonly reference to the resulting memory location
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ulong skip64<T>(in T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ulong>(ref mutable(in src)), count);

        /// <summary>
        /// Returns an readonly reference to a memory location, following a specified number of bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to skip</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref readonly T skipb<T>(in T src, long count)
            => ref Unsafe.Add(ref mutable(in src), intptr(count));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint8 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly byte const8<T>(in T src)
            => ref Unsafe.As<T,byte>(ref Unsafe.AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint16 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ushort const16<T>(in T src)
            => ref Unsafe.As<T,ushort>(ref Unsafe.AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly uint const32<T>(in T src)
            => ref Unsafe.As<T,uint>(ref Unsafe.AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ulong const64<T>(in T src)
            => ref Unsafe.As<T,ulong>(ref Unsafe.AsRef(in src));

        /// <summary>
        /// Interprets a generic reference as a uint8 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte ref8<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

        /// <summary>
        /// Interprets a generic reference as a uint16 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref ushort ref16<T>(ref T src)
            => ref Unsafe.As<T,ushort>(ref src);

        /// <summary>
        /// Interprets a generic reference as a uint32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint ref32<T>(ref T src)
            => ref Unsafe.As<T,uint>(ref src);

        /// <summary>
        /// Interprets a generic reference as a uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref ulong ref64<T>(ref T src)
            => ref Unsafe.As<T,ulong>(ref src);
    }
}