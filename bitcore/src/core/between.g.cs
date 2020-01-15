//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {    
        /// <summary>
        /// Extracts a contiguous range of bits from a primal source inclusively between two index positions
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="rhs">The left bit position</param>
        /// <param name="dst">The right bit position</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.All)]
        public static T between<T>(T src, byte p0, byte p1)
            where T : unmanaged
                => between_u(src,p0,p1);

        /// <summary>
        /// Extracts a contiguous sequence of bits from a source and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="a">The bit source</param>
        /// <param name="first">The 0-based index of the first selected bit</param>
        /// <param name="last">The 0-based index of the last selected bit</param>
        /// <param name="dst">The target that receives the sequence</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.All)]
        public static void between<T>(T a, byte first, byte last, Span<byte> dst, int offset)
            where T : unmanaged
                => bytes(gbits.between(a,first,last)).Slice(0, BitCalcs.minbytes(last - first + 1)).CopyTo(dst,offset);

        [MethodImpl(Inline)]
        static T between_i<T>(T src, byte p0, byte p1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(Bits.between(int8(src), p0, p1));
            else if(typeof(T) == typeof(short))
                 return generic<T>(Bits.between(int16(src), p0, p1));
            else if(typeof(T) == typeof(int))
                 return generic<T>(Bits.between(int32(src), p0, p1));
            else if(typeof(T) == typeof(long))
                 return generic<T>(Bits.between(int64(src), p0, p1));
            else
                return between_f(src,p0,p1);
        }

        [MethodImpl(Inline)]
        static T between_u<T>(T src, byte p0, byte p1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.between(uint8(src), p0, p1));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.between(uint16(src), p0, p1));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.between(uint32(src), p0, p1));
            else if(typeof(T) == typeof(ulong))
                 return generic<T>(Bits.between(uint64(src), p0, p1));
            else 
                return between_i(src,p0,p1);
        }

        [MethodImpl(Inline)]
        static T between_f<T>(T src, byte p0, byte p1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(Bits.between(float32(src), p0, p1));
            else if(typeof(T) == typeof(double))
                 return generic<T>(Bits.between(float64(src),  p0, p1));
            else            
                throw unsupported<T>();
        }
    }
}