//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Computes the XOR of the source value and the result of right-shifting the source by a specified offset:
        /// dst = src^(src >> offset);
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static T xorsr<T>(T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.xorsr(uint8(src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.xorsr(uint16(src), offset));                
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.xorsr(int32(src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.xorsr(uint64(src), offset));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Computes in-place the XOR of the source value and the result of right-shifting the source by a specified offset
        /// src = src^(src >> offset);
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static ref T xorsr<T>(ref T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                Bits.xorsr(ref uint8(ref src), offset);
            else if(typeof(T) == typeof(ushort))
                Bits.xorsr(ref uint16(ref src), offset);
            else if(typeof(T) == typeof(uint))
                Bits.xorsr(ref uint32(ref src), offset);
            else if(typeof(T) == typeof(ulong))
                Bits.xorsr(ref uint64(ref src), offset);
            else            
                throw unsupported<T>();
            return ref src;
        }
    }
}