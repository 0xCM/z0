//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;

    partial class bvoc
    {

        //https://stackoverflow.com/questions/17803889/set-or-reset-a-given-bit-without-branching
        public static ref ulong bitset_2(ref ulong src, int pos, bit state)
        {
            src = (src & ~(1ul << pos)) | ((ulong)state << pos);
            return ref src;            
        }
        
        
        public static ref ulong bitset_3(ref ulong src, byte pos, bit state)
            => ref BitMask.set(ref src, pos, state);
         

        [MethodImpl(Inline)]        
        public static ref ulong bitmask_set(ref ulong src, byte pos, bit state)            
        {
            if(state) BitMask.enable(ref src, pos);
            else BitMask.disable(ref src, pos);
            return ref src;
        }

        public static byte blsmsk_d8u(byte src)
            => Bits.blsmsk(src);

        public static byte blsmsk_g8u(byte src)
            => gbits.blsmsk(src);

        public static ushort blsmsk_d16u(ushort src)
            => Bits.blsmsk(src);

        public static ushort blsmsk_g16u(ushort src)
            => gbits.blsmsk(src);

        public static uint blsmsk_d32u(uint src)
            => Bits.blsmsk(src);

        public static uint blsmsk_g32u(uint src)
            => gbits.blsmsk(src);

        public static ulong blsmsk_g64u(ulong src)
            => gbits.blsmsk(src);

        public static ulong blsmsk_d64u(ulong src)
            => Bits.blsmsk(src);
    }
}