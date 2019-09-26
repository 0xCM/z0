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
        /// Computes the XOR of the source value and the result of right-shifting 
        /// the source by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static T xorsr<T>(T src, int offset)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return generic<T>(Bits.xorsr(int8(src), offset));
            else if(typematch<T,byte>())
                return generic<T>(Bits.xorsr(uint8(src), offset));
            else if(typematch<T,short>())
                return generic<T>(Bits.xorsr(int16(src), offset));
            else if(typematch<T,ushort>())
                return generic<T>(Bits.xorsr(uint16(src), offset));
            else if(typematch<T,int>())
                return generic<T>(Bits.xorsr(int32(src), offset));
            else if(typematch<T,uint>())
                return generic<T>(Bits.xorsr(uint32(src), offset));
            else if(typematch<T,long>())
                return generic<T>(Bits.xorsr(int64(src), offset));
            else if(typematch<T,ulong>())
                return generic<T>(Bits.xorsr(uint64(src), offset));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Computes in-place the XOR of the source value and the result of right-shifting 
        /// the source by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value rightwards</param>
        [MethodImpl(Inline)]
        public static ref T xorsr<T>(ref T lhs, int offset)
            where T : struct
        {
            if(typematch<T,sbyte>())
                Bits.xorsr(ref int8(ref lhs), offset);
            else if(typematch<T,byte>())
                Bits.xorsr(ref uint8(ref lhs), offset);
            else if(typematch<T,short>())
                Bits.xorsr(ref int16(ref lhs), offset);
            else if(typematch<T,ushort>())
                Bits.xorsr(ref uint16(ref lhs), offset);
            else if(typematch<T,int>())
                Bits.xorsr(ref int32(ref lhs), offset);
            else if(typematch<T,uint>())
                Bits.xorsr(ref uint32(ref lhs), offset);
            else if(typematch<T,long>())
                Bits.xorsr(ref int64(ref lhs), offset);
            else if(typematch<T,ulong>())
                Bits.xorsr(ref uint64(ref lhs), offset);
            else            
                throw unsupported<T>();
            return ref lhs;
        }
    }
}