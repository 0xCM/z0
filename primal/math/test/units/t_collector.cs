//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;

    /*
unsigned a, b, c;
unsigned sum;
unsigned MSB_carry;

sum = a + b;
MSB_carry = (unsigned)(sum < x); // 1 or 0

c = sum/2 | (MSB_carry << 31);    
     */

    public class t_collector : UnitTest<t_collector>
    {
        //http://0x80.pl/notesen/2012-07-02-average-unsigned-ints.html
        public static uint avg(uint a, uint b)
        {
            var sum = a + b;
            var carry = (uint)math.lt(sum,  a);
            var result = (sum >> 1) | (carry << 31);
            return result;
        }

        public static ref uint avg(ref uint a, uint b)
        {   
            a = avg(a,b);
            return ref a;
        }

        public static uint avg(ReadOnlySpan<uint> src)
        {
            ref readonly var reader = ref head(src);
            var result = reader;
            for(var i=1; i<src.Length; i++)
                avg(ref result, skip(in reader, i));
            return result;
        }

        public void collect_32i_check()
        {
            var c = Collector.Create(0);
            
            var data = Random.Span<int>(Pow2.T12);

            ref readonly var src = ref head(data);
            for(var i=0; i<data.Length; i++)
                c.Collect(skip(in src,i));
            
            var avg = mathspan.avg(data);
            var min = data.Min();
            var max = data.Max();

            Claim.eq(min, c.Min);
            Claim.eq(max, c.Max);
            Claim.eq(avg, (int)c.Mean);            
        }

        public void collect_32u_check()
        {
            var c = Collector.Create(0);
            
            var data = Random.Span<uint>(Pow2.T12);

            ref readonly var src = ref head(data);
            for(var i=0; i<data.Length; i++)
                c.Collect(skip(in src,i));
            
            var msAvg = mathspan.avg(data);
            var min = data.Min();
            var max = data.Max();
            
            var usAvg1 = mathspan.avgz(data);
            var usAvg2 = avg(data);
            Trace($"{usAvg1} vs {usAvg2}");


            Claim.eq(min, c.Min);
            Claim.eq(max, c.Max);
            Claim.eq(msAvg, (int)c.Mean);            
        }

    }

}