
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

        public void vadd()
        {
            using var buffer = AsmExecBuffer.Create();
            vadd(buffer,n256);
            vadd(buffer,n128);

        }

        void vadd(AsmExecBuffer buffer, N256 w)
        {

            buffer.Load(AsmCode.Load(Add256x32u, moniker("add", PrimalKind.U32,w)));
            var f = buffer.BinOp256();

            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<uint>(w);
                var y = Random.CpuVector<uint>(w);
                var z = f.Apply(x,y);
                Claim.eq(dinx.vadd(x,y),z);
            }            
        }

        void vadd(AsmExecBuffer buffer, N128 w)
        {
            buffer.Load(AsmCode.Load(Add128x32u, moniker("add", PrimalKind.U32,w)));
            var f = buffer.BinOp128();

            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<uint>(w);
                var y = Random.CpuVector<uint>(w);
                var z = f.Apply(x,y);
                Claim.eq(dinx.vadd(x,y),z);
            }            

        }

        static ReadOnlySpan<byte> Add128x32u => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0xFE,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};

        static ReadOnlySpan<byte> Add256x32u => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xFE,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
    }
}