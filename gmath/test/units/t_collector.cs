//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_collector : t_gmath<t_collector>
    {
        //http://0x80.pl/notesen/2012-07-02-average-unsigned-ints.html
        public static uint avg(uint a, uint b)
        {
            var sum = a + b;
            var carry = (uint)math.lt(sum,  a);
            var result = (sum >> 1) | (carry << 31);
            return result;
        }

        public static ulong avg(ulong a, ulong b)
        {
            var sum = a + b;
            var carry = (ulong)math.lt(sum,  a);
            var result = (sum >> 1) | (carry << 63);
            return result;
        }

        public static ref ulong avg(ref ulong a, ulong b)
        {
            a = avg(a,b);
            return ref a;
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

        public static ulong avg(ReadOnlySpan<ulong> src)
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
            
            var data = Random.Span<int>(Pow2.T10);

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
            
            var data = Random.Span<uint>(Pow2.T10, 0, uint.MaxValue/2);

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
            Claim.eq(msAvg, (uint)c.Mean);            
        }

        public void collect_64u_check()
        {
            var c = Collector.Create(0);
            
            var data = Random.Span<ulong>(Pow2.T10, 0, uint.MaxValue);

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
            Claim.eq(msAvg, (ulong)c.Mean);            
        }

        public void collect_64i_check()
        {
            var c = Collector.Create(0);
            
            var data = Random.Span<long>(Pow2.T10, int.MinValue, int.MaxValue);

            ref readonly var src = ref head(data);
            for(var i=0; i<data.Length; i++)
                c.Collect(skip(in src,i));
            
            var msAvg = mathspan.avg(data);
            var min = data.Min();
            var max = data.Max();            

            Claim.eq(min, c.Min);
            Claim.eq(max, c.Max);
            Claim.eq(msAvg, (long)c.Mean);            
        }

    }
}