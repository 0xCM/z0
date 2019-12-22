//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_gather : t_sb<t_sb_gather>
    {            
        public void gather_masks()
        {

            var m2 = BitMasks.Lsb32x8x1;
            var x2 = Bits.gather(UInt32.MaxValue, m2);
            var y2 = Bits.scatter(x2, m2).ToBitVector();
            var bv = m2.ToBitVector();
            Claim.eq(y2,bv);
            
            for(var i=0; i<y2.Width; i++)
                Claim.eq(y2[i], i % 8 == 0 ? bit.On : bit.Off);

        }

        public void sb_gather_8()
            => sb_gather_check<byte>();

        public void sb_gather_16()
            => sb_gather_check<ushort>();

        public void sb_gather_32()
            => sb_gather_check<uint>();

        public void sb_gather_64()
            => sb_gather_check<ulong>();        
    }
}