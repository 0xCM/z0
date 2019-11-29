//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vbyteswap : IntrinsicTest<t_vbyteswap>
    {   
        public void vbyteswap_basecase()
        {
            var x16 = dinx.vparts(n128, 
                0b0000000011111111, 0b1111111100000000, 
                0b1100110000110011, 0b0011001111001100,
                0b1000000000000000, 0b0000000010000000,                
                0b0000011100000111, 0b0000011100000111
                );
            var y16 = dinx.vparts(n128, 
                0b1111111100000000, 0b0000000011111111, 
                0b0011001111001100, 0b1100110000110011, 
                0b0000000010000000, 0b1000000000000000,                 
                0b0000011100000111, 0b0000011100000111 
                );

            var z16 = dinx.vbyteswap(x16);
            var z16s = z16.ToSpan();

            Claim.eq(y16,z16);            
            for(var i=0; i<z16s.Length; i+= 2)
                Claim.eq(bswap(z16s[i]), z16s[i+1]);

            var x32 = dinx.vparts(n128, 
                0xFFFF0000, 0x0000FFFF,
                0xFF000000, 0x000000FF
                );
            var y32 = dinx.vparts(n128, 
                0x0000FFFF, 0xFFFF0000,
                0x000000FF, 0xFF000000
                );
            
            var z32 = dinx.vbyteswap(x32);
            Claim.eq(y32,z32);

        }
        
        public void vbyteswap_16()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<ushort>();
                var b = bswap(bswap(a));
                Claim.eq(a,b);
            }

            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector<ushort>(n128);
                var b = dinx.vbyteswap(a);
                var sa = a.ToSpan();
                var sb = b.ToSpan();
                for(var j = 0; j<sa.Length; j++)
                    Claim.eq(bswap(sa[j]), sb[j]);
            }

            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector<ushort>(n256);
                var b = dinx.vbyteswap(a);
                var sa = a.ToSpan();
                var sb = b.ToSpan();
                for(var j = 0; j<sa.Length; j++)
                    Claim.eq(bswap(sa[j]), sb[j]);
            }

        }

        public void vbyteswap_32()
        {
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<uint>();
                var b = bswap(bswap(a));
                Claim.eq(a,b);
            }

            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector<uint>(n128);
                var b = dinx.vbyteswap(a);
                var sa = a.ToSpan();
                var sb = b.ToSpan();
                for(var j = 0; j<sa.Length; j++)
                    Claim.eq(bswap(sa[j]), sb[j]);
            }

            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector<uint>(n256);
                var b = dinx.vbyteswap(a);
                var sa = a.ToSpan();
                var sb = b.ToSpan();
                for(var j = 0; j<sa.Length; j++)
                    Claim.eq(bswap(sa[j]), sb[j]);
            }

        }

        public void vbyteswap_64()
        {
            var a = (ulong)uint.MaxValue << 32;
            var b = (ulong)uint.MaxValue;
            Claim.eq(bswap(a),b);
            Claim.eq(bswap(b),a);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<ulong>();
                var y = bswap(bswap(x));
                Claim.eq(x,y);
            }

            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector<ulong>(n128);
                var y = dinx.vbyteswap(x);
                var xs = x.ToSpan();
                var ys = y.ToSpan();
                for(var j = 0; j<xs.Length; j++)
                    Claim.eq(bswap(xs[j]), ys[j]);
            }

            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector<ulong>(n256);
                var y = dinx.vbyteswap(x);
                var xs = x.ToSpan();
                var ys = y.ToSpan();
                for(var j = 0; j<xs.Length; j++)
                    Claim.eq(bswap(xs[j]), ys[j]);
            }

        }

    }

}