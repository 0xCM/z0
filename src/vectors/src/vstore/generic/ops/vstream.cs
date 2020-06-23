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
    using static As;

    partial class VStore
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstream<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
                => vstream_u(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstream<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
                => vstream_u(src, ref dst);

        [MethodImpl(Inline)]
        static unsafe void vstream_u<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                VStoreD.vstream(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                VStoreD.vstream(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                VStoreD.vstream(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                VStoreD.vstream(v64u(src), ref uint64(ref dst));
            else
                 vstream_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstream_i<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                VStoreD.vstream(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                VStoreD.vstream(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                VStoreD.vstream(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                VStoreD.vstream(v64i(src), ref int64(ref dst));
            else
                vstream_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstream_f<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                VStoreD.vstream(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                VStoreD.vstream(v64f(src), ref float64(ref dst));
            else 
                throw Unsupported.define<T>();                
        }

        [MethodImpl(Inline)]
        static unsafe void vstream_u<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                VStoreD.vstream(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                VStoreD.vstream(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                VStoreD.vstream(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                VStoreD.vstream(v64u(src), ref uint64(ref dst));
            else
                 vstream_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstream_i<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                VStoreD.vstream(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                VStoreD.vstream(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                VStoreD.vstream(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                VStoreD.vstream(v64i(src), ref int64(ref dst));
            else
                vstream_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstream_f<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                VStoreD.vstream(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                VStoreD.vstream(v64f(src), ref float64(ref dst));
            else 
                throw Unsupported.define<T>();                
        }
    }
}