
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    
    using static zfunc;


    public class t_or_asm : AsmOpTest<t_or_asm>
    {        
        protected override string OpName 
            => "or";

        public void asmor_check()
        {
            using var buffer = AsmExecBuffer.Create();
            asmor_check(buffer);
        }

        public void asmor_bench()
        {
            using var buffer = AsmExecBuffer.Create();
            asmor_bench(buffer);
        }

        void asmor_check(in AsmExecBuffer buffer)
        {
            or_check(buffer, Or32uCode, z32);
            or_check(buffer, Or64uCode, z64);            
        }

        void or_check<T>(in AsmExecBuffer buffer, ReadOnlySpan<byte> code,  T t = default)
            where T : unmanaged
        {
            buffer.Load(code, TestOpName(t));
            CheckMatch(gmath.or<T>, buffer.BinOp<T>());
        }

        void asmor_bench(in AsmExecBuffer buffer)        
        {
            buffer.Load(Or32uCode, TestOpName(z32));            
            asmor_bench<uint>(buffer);

            buffer.Load(Or64uCode, TestOpName(z64));            
            asmor_bench<ulong>(buffer);
        }
    
        void asmor_bench<T>(in AsmExecBuffer buffer)
            where T : unmanaged
                => RunBench(buffer.BinOp<T>(), gmath.or<T>);

        static ReadOnlySpan<byte> Or64uCode 
            => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};

        static ReadOnlySpan<byte> Or32uCode
            => new byte[]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};


    }
}



