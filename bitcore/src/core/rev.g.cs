//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {                        
        /// <summary>
        /// Reverses the bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.UnsignedInts)]
        public static T rev<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rev(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rev(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rev(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rev(uint64(src)));
            else            
                throw unsupported<T>();
        }
    }

}