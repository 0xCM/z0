//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// Extracts a contiguous sequence of bits defined by an inclusive index range
        /// </summary>
        /// <param name="a">The bit source</param>
        /// <param name="min">The first bit selected</param>
        /// <param name="max">The last bit selected</param>
        [MethodImpl(Inline)]
        public static T range<T>(T a, uint min, uint max)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.range(uint8(a), min, max));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.range(uint16(a), min, max));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.range(uint32(a), min, max));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.range(uint64(a), min, max));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Extracts a contiguous sequence of bits from a source and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="a">The bit source</param>
        /// <param name="min">The first bit selected</param>
        /// <param name="max">The last bit selected</param>
        /// <param name="dst">The target that receives the sequence</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static void range<T>(T a, uint min, uint max, Span<byte> dst, int offset)
            where T : unmanaged
                => bytes(gbits.range(a,min,max)).Slice(0, ByteCount(max - min + 1)).CopyTo(dst,offset);                 

        [MethodImpl(Inline)]
        static int ByteCount(uint bitcount)
            => (int)(Mod8.div(bitcount) + (Mod8.mod(bitcount) == 0 ? 0 : 1));

    }

}