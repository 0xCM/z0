
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_asm_intrinsic : AsmOpTest<t_asm_intrinsic>
    {        
        protected override string OpName 
            => "vadd";

        protected AsmCode<T> ReadAsm<W,T>(W w = default, T t = default)
            where T : unmanaged
            where W : unmanaged, ITypeNat
                => AsmLib.Intrinsic<T>(moniker(OpName, PrimalType.kind<T>(), n256));

        public void vadd()
        {
            using var buffer = AsmExecBuffer.Create();
            vadd_check(buffer, n256, ReadAsm(n256,z16));
            vadd_check(buffer, n256, ReadAsm(n256,z32));
        }

        void vadd_check<T>(AsmExecBuffer buffer, N128 w, AsmCode<T> asm)
            where T : unmanaged
        {            
            var f = buffer.BinOp128(asm);            
            CheckAction(() => CheckMatch<T>(ginx.vadd, f), CaseName(asm.Name));  
        }

        void vadd_check<T>(AsmExecBuffer buffer, N256 w, AsmCode<T> asm)
            where T : unmanaged
        {
            
            var f = buffer.BinOp256(asm);
            CheckAction(() => CheckMatch<T>(ginx.vadd, f), CaseName(asm.Name));            
        }

        AsmCode<uint> Add128x32u
            => AsmCode.Parse("0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xFE,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3", 
                moniker(OpName, n128, z32), z32);

        AsmCode<uint> Add256x32u
            => AsmCode.Parse("0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xFE,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3", 
                    moniker(OpName, n256, z32), z32);
    }
}