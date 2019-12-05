//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// Extracts a contiguous sequence of bits defined by an inclusive index range
        /// </summary>
        /// <param name="a">The bit source</param>
        /// <param name="first">The 0-based index of the first selected bit</param>
        /// <param name="last">The 0-based index of the last selected bit</param>
        [MethodImpl(Inline)]
        public static T bitseg<T>(T a, int first, int last)
        {            
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.segment(uint8(a), first, last));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.segment(uint16(a), first, last));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.segment(uint32(a), first, last));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.segment(uint64(a), first, last));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Extracts a contiguous sequence of bits from a source and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="a">The bit source</param>
        /// <param name="first">The 0-based index of the first selected bit</param>
        /// <param name="last">The 0-based index of the last selected bit</param>
        /// <param name="dst">The target that receives the sequence</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static void segment<T>(T a, int first, int last, Span<byte> dst, int offset)
            where T : unmanaged
                => bytes(gbits.bitseg(a,first,last)).Slice(0, BitCalcs.bytecount(last - first + 1)).CopyTo(dst,offset);
    }
}