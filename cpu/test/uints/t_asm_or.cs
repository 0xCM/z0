
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;
    
    using static zfunc;

    struct X128
    {
        public X128(ulong X0, ulong X1)
        {
            this.X0 = X0;
            this.X1 = X1;
        }
        public ulong X0;

        public ulong X1;
    }

    public class t_asm_or : AsmOpTest<t_asm_or>
    {        

        static ReadOnlySpan<byte> Or64uCode 
            => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};

        static ReadOnlySpan<byte> VOr128Code
            => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xDB,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};

        protected override int CycleCount => Pow2.T03;

        public void asm_vor_128x64u_check()
        {
            using var asm = AsmDynamic.Create(VOr128Code);         
            var or = asm.BinOp<X128>();
            for(var i=0; i< SampleSize; i++)
            {
                var x = new X128(8, 16);                
                var y = new X128(2, 4);
                var z1 = or(x,y);
                var z2 = new X128(8 | 2, 16 | 4);
                Claim.eq(z1.X0,z2.X0);
                Claim.eq(z1.X1,z2.X1);

            }
            
        }

        public void asm_or_64u_check()
        {
            using var asm = AsmDynamic.Create(Or64uCode);         
            var or = asm.BinOp<ulong>();
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Next<ulong>();
                var y = Random.Next<ulong>();
                var z = or(x,y);
                Claim.eq(x | y, z);

            }
            
        }

        public void asm_or_64u_bench()
        {
            using var asm = AsmDynamic.Create(Or64uCode);
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



