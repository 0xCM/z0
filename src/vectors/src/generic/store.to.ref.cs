//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Memories;
    
    partial class Vectors
    {
        /// <summary>
        /// Stores the source vector to a reference cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target reference</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vstore128_u(src, ref dst, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vstore128_i(src, ref dst, offset);
            else 
                vstore128_f(src, ref dst, offset);
        }

        /// <summary>
        /// Stores the source vector to a reference cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target reference</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vstore256_u(src, ref dst, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vstore256_i(src, ref dst, offset);
            else 
                vstore256_f(src, ref dst, offset);
        }

        [MethodImpl(Inline)]
        public static void vstore<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
                => vstore_u(src, ref dst);

        [MethodImpl(Inline)]
        public static void vstore<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
                => vstore_u(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector512<T> src, ref T dst, int offset = 0)
            where T : unmanaged
        {
            vstore(src.Lo, ref dst, offset);
            vstore(src.Hi, ref dst, offset + vcount<T>(w256));
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_u<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                Store.save(vcast8u(src), ref As.uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                Store.save(vcast16u(src), ref As.uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                Store.save(vcast32u(src), ref As.uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                Store.save(vcast64u(src), ref As.uint64(ref dst));
            else
                 vstore_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_i<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Store.save(vcast8i(src), ref As.int8(ref dst));
            else if(typeof(T) == typeof(short))
                Store.save(vcast16i(src), ref As.int16(ref dst));
            else if(typeof(T) == typeof(int))
                Store.save(vcast32i(src), ref As.int32(ref dst));
            else if(typeof(T) == typeof(long))
                Store.save(vcast64i(src), ref As.int64(ref dst));
            else
                vstore_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_f<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                Store.save(vcast32f(src), ref As.float32(ref dst));
            else if(typeof(T) == typeof(double))
                Store.save(vcast64f(src), ref As.float64(ref dst));
            else 
                throw Unsupported.define<T>();                
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_u<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                Store.save(vcast8u(src), ref As.uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                Store.save(vcast16u(src), ref As.uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                Store.save(vcast32u(src), ref As.uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                Store.save(vcast64u(src), ref As.uint64(ref dst));
            else
                 vstore_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_i<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Store.save(vcast8i(src), ref As.int8(ref dst));
            else if(typeof(T) == typeof(short))
                Store.save(vcast16i(src), ref As.int16(ref dst));
            else if(typeof(T) == typeof(int))
                Store.save(vcast32i(src), ref As.int32(ref dst));
            else if(typeof(T) == typeof(long))
                Store.save(vcast64i(src), ref As.int64(ref dst));
            else
                vstore_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_f<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                Store.save(vcast32f(src), ref As.float32(ref dst));
            else if(typeof(T) == typeof(double))
                Store.save(vcast64f(src), ref As.float64(ref dst));
            else 
                throw Unsupported.define<T>();                
        }

        [MethodImpl(Inline)]
        static void vstore128_u<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                Store.save(vcast8u(src), ref As.uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                Store.save(vcast16u(src), ref As.uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                Store.save(vcast32u(src), ref As.uint32(ref dst), offset);
            else
                Store.save(vcast64u(src), ref As.uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore128_i<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Store.save(vcast8i(src), ref As.int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                Store.save(vcast16i(src), ref As.int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                Store.save(vcast32i(src), ref As.int32(ref dst), offset);
            else
                Store.save(vcast64i(src), ref As.int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore128_f<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                Store.save(vcast32f(src), ref As.float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                Store.save(vcast64f(src), ref As.float64(ref dst), offset);
            else 
                throw Unsupported.define<T>();                
        }

        [MethodImpl(Inline)]
        static void vstore256_u<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                Store.save(vcast8u(src), ref As.uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                Store.save(vcast16u(src), ref As.uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                Store.save(vcast32u(src), ref As.uint32(ref dst), offset);
            else
                Store.save(vcast64u(src), ref As.uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore256_i<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Store.save(vcast8i(src), ref As.int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                Store.save(vcast16i(src), ref As.int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                Store.save(vcast32i(src), ref As.int32(ref dst), offset);
            else
                Store.save(vcast64i(src), ref As.int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore256_f<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                Store.save(vcast32f(src), ref As.float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                Store.save(vcast64f(src), ref As.float64(ref dst), offset);
            else 
                throw Unsupported.define<T>();                
        }
    }
}