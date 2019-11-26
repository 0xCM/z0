//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_gbc_pop : t_bc<t_gbc_pop>
    {

        public void gbc_pop_64()
        {
            const int bitlen = 128;
            const int bytelen = 128/8;

            for(var i=0; i<SampleSize; i++)
            {
                var bc = Random.BitCells<ulong>(bitlen);
                var bcpop = bc.Pop();
                var expect = 0ul;
                var bcbytes = bc.Bytes;
                for(var j=0; j< bcbytes.Length; j++)
                    expect += Bits.pop(bcbytes[j]);
                Claim.eq(expect, bcpop);                
            }

            var srcSpan = Random.Span<ulong>(SampleSize);
            var spPop = Bits.pop(srcSpan);            
            var spPopExpect = 0u;
            for(var i=0; i<srcSpan.Length; i++)
                spPopExpect += gbits.pop(srcSpan[i]);
            Claim.eq(spPopExpect, spPop);

        }

    }

}