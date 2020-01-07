
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
            or_check(Or32u);
            or_check(Or64u);            
        }

        public void or_bench()
        {
            using var buffer = AsmExecBuffer.Create();            
            or_bench(buffer,Or32u);
            or_bench(buffer,Or64u);
        }

        void or_check<T>(in AsmCode<T> code)
            where T : unmanaged
                => CheckAsmMatch(gmath.or, code);

        void or_bench<T>(in AsmExecBuffer buffer, in AsmCode<T> code)
            where T : unmanaged
        {
            RunBench(gmath.or<T>, buffer.BinOp(code));
        }

        AsmCode<uint> Or32u
            => AsmCode.Load<uint>(new byte[]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3}, 
                    Moniker.define(OpName, PrimalKind.U32));

        AsmCode<ulong> Or64u
            => AsmCode.Load<ulong>(new byte[]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3}, 
                    Moniker.define(OpName, PrimalKind.U64));
    }
}



