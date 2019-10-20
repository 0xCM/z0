//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        [MethodImpl(Inline)]
        public static T segment<T>(T src, int i0, int i1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return segment_u(src,i0,i1);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return segment_i(src,i0,i1);
            else 
                return segment_f(src,i0,i1);
        }           

        [MethodImpl(Inline)]
        public static void segment<T>(T src, int i0, int i1, Span<byte> dst, int offset)
            where T : unmanaged
                => bytes(segment(src,i0,i1)).Slice(0, ByteCount(i0,i1)).CopyTo(dst,offset);                 

        [MethodImpl(Inline)]
        static T segment_i<T>(T src, int i0, int i1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.segment(int8(src), i0,i1));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.segment(int16(src), i0,i1));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.segment(int32(src), i0,i1));
            else 
                return generic<T>(Bits.segment(int64(src), i0,i1));
        }           

        [MethodImpl(Inline)]
        static T segment_u<T>(T src, int i0, int i1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.segment(uint8(src), i0,i1));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.segment(uint16(src), i0,i1));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.segment(uint32(src), i0,i1));
            else 
                return generic<T>(Bits.segment(uint64(src), i0,i1));
        }           

        [MethodImpl(Inline)]
        static T segment_f<T>(T src, int i0, int i1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(Bits.segment(float32(src), i0,i1));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.segment(float64(src), i0,i1));
            else 
                throw unsupported<T>();
        }           

    }
}