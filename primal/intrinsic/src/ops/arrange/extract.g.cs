//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Extract a component from a 128-bit cpu vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vextract_u(src,index);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vextract_i(src,index);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N0 n)
            where T : unmanaged
                => src.GetElement(0);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N1 n)
            where T : unmanaged
                => src.GetElement(1);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N2 n)
            where T : unmanaged
                => src.GetElement(2);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N3 n)
            where T : unmanaged
                => src.GetElement(3);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N4 n)
            where T : unmanaged
                => src.GetElement(4);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N5 n)
            where T : unmanaged
                => src.GetElement(5);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N6 n)
            where T : unmanaged
                => src.GetElement(6);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N7 n)
            where T : unmanaged
                => src.GetElement(7);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N8 n)
            where T : unmanaged
                => src.GetElement(8);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N9 n)
            where T : unmanaged
                => src.GetElement(9);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N10 n)
            where T : unmanaged
                => src.GetElement(10);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N11 n)
            where T : unmanaged
                => src.GetElement(11);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N12 n)
            where T : unmanaged
                => src.GetElement(12);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N13 n)
            where T : unmanaged
                => src.GetElement(13);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N14 n)
            where T : unmanaged
                => src.GetElement(14);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, N15 n)
            where T : unmanaged
                => src.GetElement(15);
        
        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N0 n)
            where T : unmanaged
                => src.GetElement(0);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N1 n)
            where T : unmanaged
                => src.GetElement(1);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N2 n)
            where T : unmanaged
                => src.GetElement(2);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N3 n)
            where T : unmanaged
                => src.GetElement(3);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N4 n)
            where T : unmanaged
                => src.GetElement(4);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N5 n)
            where T : unmanaged
                => src.GetElement(5);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N6 n)
            where T : unmanaged
                => src.GetElement(6);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N7 n)
            where T : unmanaged
                => src.GetElement(7);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N8 n)
            where T : unmanaged
                => src.GetElement(8);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N9 n)
            where T : unmanaged
                => src.GetElement(9);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N10 n)
            where T : unmanaged
                => src.GetElement(10);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N11 n)
            where T : unmanaged
                => src.GetElement(11);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N12 n)
            where T : unmanaged
                => src.GetElement(12);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N13 n)
            where T : unmanaged
                => src.GetElement(13);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N14 n)
            where T : unmanaged
                => src.GetElement(14);

        [MethodImpl(Inline)]
        public static T vextract<T>(Vector256<T> src, N15 n)
            where T : unmanaged
                => src.GetElement(15);

        [MethodImpl(Inline)]
        static T vextract_i<T>(Vector128<T> src, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vextract(int8(src), index));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vextract(int16(src), index));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vextract(int32(src), index));
            else 
                return generic<T>(dinx.vextract(int64(src), index));
        }

        [MethodImpl(Inline)]
        static T vextract_u<T>(Vector128<T> src, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vextract(uint8(src), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vextract(uint16(src), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vextract(int64(src), index));
            else 
                return generic<T>(dinx.vextract(uint64(src), index));
        }

 
    }
}