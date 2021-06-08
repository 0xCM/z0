//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        /// <summary>
        /// Captures instruction format content such as '0100 0R0B : 0001 000w : 11 reg1 reg2'
        /// </summary>
        public struct InstructionFormat
        {
            public string Mnemonic;

            public string Description;
        }

        /* Examples

            ADC – ADD with Carry
            register1 to register2
            0100 0R0B : 0001 000w : 11 reg1 reg2
            qwordregister1 to qwordregister2
            0100 1R0B : 0001 0001 : 11 qwordreg1 qwordreg2
            register2 to register1
            0100 0R0B : 0001 001w : 11 reg1 reg2
            qwordregister1 to qwordregister2
            0100 1R0B : 0001 0011 : 11 qwordreg1 qwordreg2
            memory to register
            0100 0RXB : 0001 001w : mod reg r/m
            memory to qwordregister
            0100 1RXB : 0001 0011 : mod qwordreg r/m
            register to memory
            0100 0RXB : 0001 000w : mod reg r/m
            qwordregister to memory
            0100 1RXB : 0001 0001 : mod qwordreg r/m
            immediate to register
            0100 000B : 1000 00sw : 11 010 reg : immediate
            immediate to qwordregister
            0100 100B : 1000 0001 : 11 010 qwordreg : imm32
            immediate to qwordregister
            0100 1R0B : 1000 0011 : 11 010 qwordreg : imm8

        */
    }
}