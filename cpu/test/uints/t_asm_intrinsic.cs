
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;
    
    using static zfunc;


    public class t_asm_intrinsic : AsmOpTest<t_asm_intrinsic>
    {        


        public unsafe void Verify()
        {
            var code = AsmCode.Load(Add256x32u, moniker("add", PrimalKind.U32,n256));
            using var buffer = AsmExecBuffer.Create();
            buffer.Load(code);
            // var f = buffer.BinOp<IntPtr>();
            // var x = Random.CpuVector<uint>(n256);
            // var y = Random.CpuVector<uint>(n256);
            // var z = f(intptr(&y), intptr(&y));
            
            // var result = f(x,y);

            
        }

        static ReadOnlySpan<byte> Add256x32u => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0xFE,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
    }
}