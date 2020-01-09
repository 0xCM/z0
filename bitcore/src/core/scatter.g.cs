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
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The scatter spec</param>
        /// <typeparam name="T">The identifiying mask</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInts)]
        public static T scatter<T>(T src, T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.scatter(uint8(src), uint8(mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.scatter(uint16(src), uint16(mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.scatter(uint32(src), uint32(mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.scatter(uint64(src), uint64(mask)));
            else            
                throw unsupported<T>();
        }           
    }
}