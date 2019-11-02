//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bvpop : BitVectorTest<t_bvpop>
    {

        
        
        public void pop_generic()
        {
            BitSize bitlen = 128 + 8;
            ByteSize bytelen = (ByteSize)bitlen;
            Claim.eq((int)bytelen, (int)bitlen/8);
            for(var i=0; i<CycleCount; i++)
            {
                var bv = Random.BitCells<ulong>(bitlen);
                var actual = bv.Pop();
                var expect = 0ul;
                var bytes = bv.Bytes;
                for(var j=0; j< bytes.Length; j++)
                    expect += Bits.pop(bytes[j]);
                Claim.eq(expect, actual);
                
            }

        }

        public void pop_spans()
        {
            var src = Random.Span<ulong>(SampleSize);
            var actual = bitspan.pop(src);
            
            var expect = 0u;
            for(var i=0; i<src.Length; i++)
            {
                expect += gbits.pop(src[i]);
            }
            Claim.eq(expect, actual);
        }


    }

}