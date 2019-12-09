//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vcpu_pop : t_vcpu<t_vcpu_pop>
    {

        public void vcpu_pop_3x256()
        {
            var n = n256;
            var blocks = 3;
            var cells = blocks*4;
            var src = Random.Blocks<ulong>(n, blocks, (0,uint.MaxValue));
            Claim.eq(cells, src.CellCount);

            var x0 = src.LoadVector(0);
            var x1 = src.LoadVector(1);
            var x2 = src.LoadVector(2);
            var pop2 = 0u;
            var pop3 = 0u;
            for(var i=0; i< src.CellCount; i++)
            {
                pop2 += Bits.pop(src[i]);
                pop3 += Bits.pop(src[i],0,0);
            }

            var pop1 = CpuBits.vpop(x0,x1,x2);
            Claim.eq(pop2,pop3);
            Claim.eq(pop1,pop3);
        }

        public void vcpu_pop_3x128()
        {
            var n = n128;
            var blocks = 3;
            var cells = blocks*2;
            var src = Random.Blocks<ulong>(n, blocks, (0,uint.MaxValue));
            Claim.eq(cells, src.CellCount);

            var x0 = src.LoadVector(0);
            var x1 = src.LoadVector(1);
            var x2 = src.LoadVector(2);
            var pop2 = 0u;
            var pop3 = 0u;
            for(var i=0; i< src.CellCount; i++)
            {
                pop2 += Bits.pop(src[i]);
                pop3 += Bits.pop(src[i],0,0);
            }

            var pop1 = CpuBits.vpop(x0,x1,x2);
            Claim.eq(pop2,pop3);
            Claim.eq(pop1,pop3);
        }

        public void vcpu_pop_bench()
        {
            scalar_pop_1x64_popcnt_bench();
            scalar_pop_1x64_lookup_bench();
            vcpu_pop_3x128_bench();
            vcpu_pop_3x256_bench();
        }

        void vcpu_pop_3x256_bench(SystemCounter counter = default, N256 n = default)
        {
            
            var total = 0ul;
            var opcount = 0;
            for(var cycle = 0; cycle < CycleCount; cycle++)
            {
                var x = Random.CpuVector<ulong>(n);
                var y = Random.CpuVector<ulong>(n);
                var z = Random.CpuVector<ulong>(n);
                counter.Start();
                for(var i=0; i<SampleSize; i++)
                    total += CpuBits.vpop(x,y,z);
                counter.Stop();
                opcount += (32 * 3 * SampleSize);
            }
            Benchmark($"pop_3x256", counter, opcount);
        }

        void vcpu_pop_3x128_bench(SystemCounter counter = default, N128 n = default)
        {            
            var total = 0ul;
            var opcount = 0;
            for(var cycle = 0; cycle < CycleCount; cycle++)
            {
                var x = Random.CpuVector<ulong>(n);
                var y = Random.CpuVector<ulong>(n);
                var z = Random.CpuVector<ulong>(n);
                counter.Start();
                for(var i=0; i<SampleSize; i++)
                    total += CpuBits.vpop(x,y,z);
                counter.Stop();
                opcount += (16 * 3 * SampleSize);
            }
            Benchmark($"pop_3x128", counter, opcount);
        }

        void scalar_pop_1x64_popcnt_bench(SystemCounter counter = default)
        {            
            var total = 0u;
            var opcount = 0;
            Span<ulong> samples = stackalloc ulong[SampleSize];
            ref readonly var src = ref head(samples);
            for(var cycle = 0; cycle < CycleCount; cycle++)
            {
                Random.Fill(SampleSize, ref head(samples));
                counter.Start();
                for(var i=0; i< SampleSize; i++)
                    total += Bits.pop(skip(in head(samples), i));
                counter.Stop();
                opcount += 8*1*SampleSize;
            }
            Benchmark($"pop_1x64_popcnt", counter, opcount);
        }

        void scalar_pop_1x64_lookup_bench(SystemCounter counter = default)
        {
            
            var total = 0;
            var opcount = 0;
            Span<ulong> samples = stackalloc ulong[SampleSize];
            ref readonly var src = ref head(samples);
            for(var cycle = 0; cycle < CycleCount; cycle++)
            {
                Random.Fill(SampleSize, ref head(samples));
                counter.Start();
                for(var i=0; i< SampleSize; i++)
                    total += BitStore.pop(skip(in head(samples), i));
                counter.Stop();
                opcount += 8*1*SampleSize;

            }
            Benchmark($"pop_1x64_lookup", counter, opcount);
        }
    }
}