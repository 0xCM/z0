//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct ScalarStore
    {
        /// <summary>
        /// Writes a source to a target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T store<S,T>(in S src, out T dst)
        {
            dst = @as<S,T>(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Int8k)]
        public static ref byte store<T>(in T src, out byte dst)
            where T : unmanaged
        {
            dst = 0;
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                store(w8, src, ref dst);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Int8x16k)]
        public static ref ushort store<T>(in T src, out ushort dst)
            where T : unmanaged
        {
            dst = 0;
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                store(w8, src, ref dst);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short) || typeof(T) == typeof(char))
                store(w16, src, ref dst);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Int8x16x32k)]
        public static ref uint store<T>(in T src, out uint dst)
            where T : unmanaged
        {
            dst = 0u;
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                store(w8, src, ref dst);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short) || typeof(T) == typeof(char))
                store(w16, src, ref dst);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                store(w32, src, ref dst);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref ulong store<T>(in T src, out ulong dst)
            where T : unmanaged
        {
            dst = 0ul;
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                store(w8, src, ref dst);
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short) || typeof(T) == typeof(char))
                store(w16, src, ref dst);
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                store(w32, src, ref dst);
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(ulong))
                store(w64, src, ref dst);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Int8k)]
        public static ref byte store<T>(W8 w, in T src, ref byte dst)
            where T : unmanaged
        {
            ref var cell = ref @as<T,byte>(src);
            dst = cell;
            return ref cell;
        }

        [MethodImpl(Inline), Op, Closures(Int8k)]
        public static ref byte store<T>(W8 w, in T src, ref ushort dst)
            where T : unmanaged
        {
            ref var cell = ref @as<T,byte>(src);
            dst = cell;
            return ref cell;
        }

        [MethodImpl(Inline), Op, Closures(Int16k)]
        public static ref ushort store<T>(W16 w, in T src, ref ushort dst)
            where T : unmanaged
        {
            ref var cell = ref @as<T,ushort>(src);
            dst = cell;
            return ref cell;
        }

        [MethodImpl(Inline), Op, Closures(Int8k)]
        public static ref byte store<T>(W8 w, in T src, ref uint dst)
            where T : unmanaged
        {
            ref var cell = ref @as<T,byte>(src);
            dst = cell;
            return ref cell;
        }

        [MethodImpl(Inline), Op, Closures(Int16k)]
        public static ref ushort store<T>(W16 w, in T src, ref uint dst)
            where T : unmanaged
        {
            ref var cell = ref @as<T,ushort>(src);
            dst = cell;
            return ref cell;
        }

        [MethodImpl(Inline), Op, Closures(Int32k)]
        public static ref uint store<T>(W32 w, in T src, ref uint dst)
            where T : unmanaged
        {
            ref var cell = ref @as<T,uint>(src);
            dst = cell;
            return ref cell;
        }

        [MethodImpl(Inline), Op, Closures(Int8k)]
        public static ref byte store<T>(W8 w, in T src, ref ulong dst)
            where T : unmanaged
        {
            ref var cell = ref @as<T,byte>(src);
            dst = cell;
            return ref cell;
        }

        [MethodImpl(Inline), Op, Closures(Int16k)]
        public static ref ushort store<T>(W16 w, in T src, ref ulong dst)
            where T : unmanaged
        {
            ref var cell = ref @as<T,ushort>(src);
            dst = cell;
            return ref cell;
        }

        [MethodImpl(Inline), Op, Closures(Int32k)]
        public static ref uint store<T>(W32 w, in T src, ref ulong dst)
            where T : unmanaged
        {
            ref var cell = ref @as<T,uint>(src);
            dst = cell;
            return ref cell;
        }

        [MethodImpl(Inline), Op, Closures(Int64k)]
        public static ref ulong store<T>(W64 w, in T src, ref ulong dst)
            where T : unmanaged
        {
            ref var cell = ref @as<T,ulong>(src);
            dst = cell;
            return ref cell;
        }

        /// <summary>
        /// Fills a caller-supplied span with data produced by a T-enumerable
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> store<T>(IEnumerable<T> src, Span<T> dst)
        {
            var i = 0u;
            var e = sys.enumerator(src);
            while(sys.next(e) && i < dst.Length)
                seek(dst,i) = sys.current(e);
            return dst;
        }
    }
}