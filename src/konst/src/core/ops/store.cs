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

    using static Konst;
    using static Typed;

    partial struct core
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
            dst = core.@as<S,T>(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ulong store<T>(in T src, out ulong dst) 
            where T : unmanaged
        {
            dst = 0ul;
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))            
                store(w8, src, ref dst);
            else if(typeof(T) == typeof(ushort))            
                store(w16, src, ref dst);
            else if(typeof(T) == typeof(uint))            
                store(w32, src, ref dst);
            else if(typeof(T) == typeof(ulong))            
                store(w64, src, ref dst);
            // var eSize = core.size<T>();
            // if(eSize == 1)
            //     store(w8, src, ref dst);
            // else if(eSize == 2)
            //     store(w16, src, ref dst);
            // else if(eSize == 4)
            //     store(w32, src, ref dst);
            // else
            //     store(w64, src, ref dst);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Int8k | UInt8k)]
        public static ref byte store<T>(W8 w, in T src, ref ulong dst) 
            where T : unmanaged
        {
            ref var u8 = ref core.@as<T,byte>(src);
            dst = u8;
            return ref u8;
        }

        [MethodImpl(Inline), Op, Closures(Int16k | UInt16k)]
        public static ref ushort store<T>(W16 w, in T src, ref ulong dst) 
            where T : unmanaged
        {
            ref var tVal = ref core.@as<T,ushort>(src);
            dst = tVal;
            return ref tVal;
        }

        [MethodImpl(Inline), Op, Closures(Int32k | UInt32k)]
        public static ref uint store<T>(W32 w, in T src, ref ulong dst) 
            where T : unmanaged
        {
            ref var tVal = ref core.@as<T,uint>(src);
            dst = tVal;
            return ref tVal;
        }

        [MethodImpl(Inline), Op, Closures(Int64k | UInt64k)]
        public static ref ulong store<T>(W64 w, in T src, ref ulong dst) 
            where T : unmanaged
        {
            ref var tVal = ref core.@as<T,ulong>(src);
            dst = tVal;
            return ref tVal;
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
                core.seek(dst,i) = sys.current(e);
            return dst;
        }    

        [Op]
        public static void store(in StringRef src, ref char dst, uint offset = 0)
        {
            var c = core.data(src);
            var k = c.Length;
            for(uint i=0, o = offset; i<k; i++, o++)
                seek(dst,o) = skip(c,i);
        }
    }
}