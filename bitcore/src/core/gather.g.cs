//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {                       
        /// <summary>
        /// Extracts mask-identified bits from the source and deposits the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.UnsignedInts)]
        public static T gather<T>(T src, T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.gather(uint8(src), uint8(mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.gather(uint16(src), uint16(mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.gather(uint32(src), uint32(mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.gather(uint64(src), uint64(mask)));
            else            
                throw unsupported<T>();
        }           
    }
}