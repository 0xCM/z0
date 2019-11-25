//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_pbv_concat : t_bv<t_pbv_concat>
    {
        public void bv_inc_8()
        {            
            var bv = BitVector8.Zero;
            var counter = 0;
            do
                Claim.eq(counter++, (byte)bv);            
            while(++bv);

            Claim.eq(counter, Pow2.T08);
        }
 

        public void bv_concat_8()
        {
            var head = BitVector.from(n8,0b10100);
            var tail = BitVector.from(n8,0b111);
            var whole = head.Concat(tail);
            Claim.eq(head, whole.Hi);
            Claim.eq(tail, whole.Lo);
            var bsWhole = whole.ToBitString();
            var bsHead = head.ToBitString();
            var bsTail = tail.ToBitString();
            Claim.eq(bsWhole, bsHead + bsTail);        
        }
    }
}