
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    
    using static zfunc;


    public class t_asm_or : AsmOpTest<t_asm_or>
    {        

        static ReadOnlySpan<byte> Or64uCode 
            => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};

        static ReadOnlySpan<byte> Or32uCode
            => new byte[]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};

        protected override int CycleCount => Pow2.T03;

        public void asm_or_64u_check()
        {
            using var asm = AsmBuffer.Create(Or64uCode);         
            var or = asm.BinOp<ulong>();
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<ulong>();
                var y = Random.Next<ulong>();
                var z = or(x,y);
                Claim.eq(x | y, z);

            }
        }

        public void asm_or_32u_check()
        {
            using var asm = AsmBuffer.Create(Or32uCode);         
            var or = asm.BinOp<uint>();
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<uint>();
                var y = Random.Next<uint>();
                var z = or(x,y);
                Claim.eq(x | y, z);
            }            
        }

        public void asm_or_64u_bench()
        {
            using var asm = AsmBuffer.Create(Or64uCode);
            asm_binop_bench(asm.BinOp<ulong>());
            or64u_bench();
        }

        void or64u_bench(SystemCounter counter = default)
        {
            var last = 0ul;
            for(var i=0; i<OpCount; i++)
            {
                var x = Random.Next<ulong>();
                var y = Random.Next<ulong>();
                counter.Start();
                last = x | y;
                counter.Stop();
            }

            Benchmark("or_cs_64u",counter);
        }

        void asm_binop_bench<T>(AsmBinOp<T> op, SystemCounter counter = default)
            where T :unmanaged
        {
            var last = default(T);
            for(var i=0; i<OpCount; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                counter.Start();
                last = op(x,y);
                counter.Stop();
            }

            Benchmark("or_asm_64u",counter);
        }
    }
}



