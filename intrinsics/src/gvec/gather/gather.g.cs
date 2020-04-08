//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Gone2;    
    using static Seed; using static Memories;
    using static AsIn;
        
    partial class gvec
    {
        [MethodImpl(Inline), Op, Closures(NumericKind.Integers)]
        public static Vector128<T> vgather<T>(in T src, Vector128<T> vidx)
            where T : unmanaged        
                => vgather_u(n128,src,vidx);

        [MethodImpl(Inline), Op, Closures(NumericKind.Integers)]
        public static Vector256<T> vgather<T>(in T src, Vector256<T> vidx)
            where T : unmanaged        
                => vgather_u(n256,src,vidx);

        [MethodImpl(Inline), Op, Closures(NumericKind.Integers)]
        public static Vector128<T> vgather<T>(ReadOnlySpan<T> src, Vector128<T> vidx)
            where T : unmanaged        
                => vgather_u(n128, head(src),vidx);

        [MethodImpl(Inline), Op, Closures(NumericKind.Integers)]
        public static Vector256<T> vgather<T>(ReadOnlySpan<T> src, Vector256<T> vidx)
            where T : unmanaged        
                => vgather_u(n256, head(src), vidx);

        [MethodImpl(Inline)]
        static Vector128<T> vgather_u<T>(N128 w, in T src, Vector128<T> vidx)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vgather(w, in uint8(in src), v8u(vidx)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vgather(w, in uint16(in src), v16u(vidx)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vgather(w, in uint32(in src), v32u(vidx)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vgather(w, in uint64(in src), v64u(vidx)));
            else 
                return vgather_i(w,src,vidx);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vgather_i<T>(N128 w, in T src, Vector128<T> vidx)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dvec.vgather(w, in int8(in src), v8i(vidx)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dvec.vgather(w, in int16(in src), v16i(vidx)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dvec.vgather(w, in int32(in src), v32i(vidx)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dvec.vgather(w, in int64(in src), v64i(vidx)));
            else 
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vgather_u<T>(N256 w, in T src, Vector256<T> vidx)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vgather(w, in uint8(in src), v8u(vidx)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vgather(w, in uint16(in src), v16u(vidx)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vgather(w, in uint32(in src), v32u(vidx)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vgather(w, in uint64(in src), v64u(vidx)));
            else 
                return vgather_i(w,src,vidx);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vgather_i<T>(N256 w, in T src, Vector256<T> vidx)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dvec.vgather(w, in int8(in src), v8i(vidx)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dvec.vgather(w, in int16(in src), v16i(vidx)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dvec.vgather(w, in int32(in src), v32i(vidx)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dvec.vgather(w, in int64(in src), v64i(vidx)));
            else 
                throw Unsupported.define<T>();
        }
    }
}