//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using llvm;
    using static Root;

    using static AsmOperands;

    [ApiHost]
    public readonly partial struct AsmOps
    {
        public readonly struct VPTERNLOGDZ128rmi
        {
            public const string Expression = "xmm0, xmm1, xmmword ptr [r8], 0x21";

            public const string Prototype = "[vpternlogd, Reg:xmm0, Reg:xmm1, Memory: ModeSize=64,Size=128,BaseReg=r8,Scale=1, Imm:33]";

            public const AsmId OpCode = AsmId.VPTERNLOGDZ128rmi;

            public readonly xmm Op0;

            public readonly xmm Op1;

            public readonly m128 Op2;

            [MethodImpl(Inline)]
            public VPTERNLOGDZ128rmi(xmm op0, xmm op1, m128 op2)
            {
                Op0 = op0;
                Op1 = op1;
                Op2 = op2;
            }
        }

        [MethodImpl(Inline), Op]
        public static VPTERNLOGDZ128rmi vpternlog(xmm op0, xmm op1, m128 op2)
            => new VPTERNLOGDZ128rmi(op0,op1,op2);

        // public static m128 mem128(r64 @base, MemoryScale scale, imm8 disp)
        //     => new m128()


    }

    /*

    [vpternlogd, Reg:xmm0, Reg:xmm1, Memory: ModeSize=64,Size=128,BaseReg=r8,Scale=1, Imm:33]
	vpternlogd	xmm0, xmm1, xmmword ptr [r8], 0x21	# encoding: [0x62,0xd3,0x75,0x08,0x25,0x00,0x21]
                                        # encoding: [0x62,0xd3,0x75,0x08,0x25,0x00,0x21]
                                        # <MCInst #13750 VPTERNLOGDZ128rmi
                                        #  <MCOperand Reg:152>
                                        #  <MCOperand Reg:152>
                                        #  <MCOperand Reg:153>
                                        #  <MCOperand Reg:128>
                                        #  <MCOperand Imm:1>
                                        #  <MCOperand Reg:0>
                                        #  <MCOperand Imm:0>
                                        #  <MCOperand Reg:0>
                                        #  <MCOperand Imm:33>>


    [vpternlogd, Reg:xmm0, {, Reg:k1, }, Reg:xmm1, Memory: ModeSize=64,Size=128,BaseReg=r8,Scale=1, Imm:33]
	vpternlogd	xmm0 {k1}, xmm1, xmmword ptr [r8], 0x21	# encoding: [0x62,0xd3,0x75,0x09,0x25,0x00,0x21]
                                        # encoding: [0x62,0xd3,0x75,0x09,0x25,0x00,0x21]
                                        # <MCInst #13751 VPTERNLOGDZ128rmik
                                        #  <MCOperand Reg:152>
                                        #  <MCOperand Reg:152>
                                        #  <MCOperand Reg:113>
                                        #  <MCOperand Reg:153>
                                        #  <MCOperand Reg:128>
                                        #  <MCOperand Imm:1>
                                        #  <MCOperand Reg:0>
                                        #  <MCOperand Imm:0>
                                        #  <MCOperand Reg:0>
                                        #  <MCOperand Imm:33>>

    [vpternlogd, Reg:ymm0, Reg:ymm1, Memory: ModeSize=64,Size=256,BaseReg=r8,Scale=1, Imm:33]
	vpternlogd	xmm0 {k1} {z}, xmm1, xmmword ptr [r8], 0x21
                                        # encoding: [0x62,0xd3,0x75,0x89,0x25,0x00,0x21]
                                        # <MCInst #13752 VPTERNLOGDZ128rmikz
                                        #  <MCOperand Reg:152>
                                        #  <MCOperand Reg:152>
                                        #  <MCOperand Reg:113>
                                        #  <MCOperand Reg:153>
                                        #  <MCOperand Reg:128>
                                        #  <MCOperand Imm:1>
                                        #  <MCOperand Reg:0>
                                        #  <MCOperand Imm:0>
                                        #  <MCOperand Reg:0>
                                        #  <MCOperand Imm:33>>

    [vpternlogd, Reg:ymm0, Reg:ymm1, Memory: ModeSize=64,Size=256,BaseReg=r8,Scale=1, Imm:33]
	vpternlogd	ymm0, ymm1, ymmword ptr [r8], 0x21
    encoding: [0x62,0xd3,0x75,0x28,0x25,0x00,0x21]
    <MCInst #13759 VPTERNLOGDZ256rmi
    <MCOperand Reg:184>
    <MCOperand Reg:184>
    <MCOperand Reg:185>
    <MCOperand Reg:128>
    <MCOperand Imm:1>
    <MCOperand Reg:0>
    <MCOperand Imm:0>
    <MCOperand Reg:0>
    <MCOperand Imm:33>>


        VPTERNLOGDZ128rmbi	= 13747,
        VPTERNLOGDZ128rmbik	= 13748,
        VPTERNLOGDZ128rmbikz	= 13749,
        VPTERNLOGDZ128rmi	= 13750,
        VPTERNLOGDZ128rmik	= 13751,
        VPTERNLOGDZ128rmikz	= 13752,
        VPTERNLOGDZ128rri	= 13753,
        VPTERNLOGDZ128rrik	= 13754,
        VPTERNLOGDZ128rrikz	= 13755,
        VPTERNLOGDZ256rmbi	= 13756,
        VPTERNLOGDZ256rmbik	= 13757,
        VPTERNLOGDZ256rmbikz	= 13758,
        VPTERNLOGDZ256rmi	= 13759,
        VPTERNLOGDZ256rmik	= 13760,
        VPTERNLOGDZ256rmikz	= 13761,
        VPTERNLOGDZ256rri	= 13762,
        VPTERNLOGDZ256rrik	= 13763,
        VPTERNLOGDZ256rrikz	= 13764,
        VPTERNLOGDZrmbi	= 13765,
        VPTERNLOGDZrmbik	= 13766,
        VPTERNLOGDZrmbikz	= 13767,
        VPTERNLOGDZrmi	= 13768,
        VPTERNLOGDZrmik	= 13769,
        VPTERNLOGDZrmikz	= 13770,
        VPTERNLOGDZrri	= 13771,
        VPTERNLOGDZrrik	= 13772,
        VPTERNLOGDZrrikz	= 13773,
        VPTERNLOGQZ128rmbi	= 13774,
        VPTERNLOGQZ128rmbik	= 13775,
        VPTERNLOGQZ128rmbikz	= 13776,
        VPTERNLOGQZ128rmi	= 13777,
        VPTERNLOGQZ128rmik	= 13778,
        VPTERNLOGQZ128rmikz	= 13779,
        VPTERNLOGQZ128rri	= 13780,
        VPTERNLOGQZ128rrik	= 13781,
        VPTERNLOGQZ128rrikz	= 13782,
        VPTERNLOGQZ256rmbi	= 13783,
        VPTERNLOGQZ256rmbik	= 13784,
        VPTERNLOGQZ256rmbikz	= 13785,
        VPTERNLOGQZ256rmi	= 13786,
        VPTERNLOGQZ256rmik	= 13787,
        VPTERNLOGQZ256rmikz	= 13788,
        VPTERNLOGQZ256rri	= 13789,
        VPTERNLOGQZ256rrik	= 13790,
        VPTERNLOGQZ256rrikz	= 13791,
        VPTERNLOGQZrmbi	= 13792,
        VPTERNLOGQZrmbik	= 13793,
        VPTERNLOGQZrmbikz	= 13794,
        VPTERNLOGQZrmi	= 13795,
        VPTERNLOGQZrmik	= 13796,
        VPTERNLOGQZrmikz	= 13797,
        VPTERNLOGQZrri	= 13798,
        VPTERNLOGQZrrik	= 13799,
        VPTERNLOGQZrrikz	= 13800,

    */
}