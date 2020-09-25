//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public readonly struct AsmOperation
    {
        public Sequential Sequence {get;}

        public AsmOperationKey Key {get;}

        public AsmMnemonic Mnemonic {get;}

        public AsmOpCodeExpression OpCode {get;}

        public AsmInstructionPattern Instruction {get;}

        public AsmOperatingMode Mode {get;}

        public CpuidExpression Cpuid {get;}
    }

    /// <summary>
    /// Defines encoded instruction content
    /// </summary>
    public readonly struct AsmOperationCode
    {
        readonly Vector128<byte> Data;

        [MethodImpl(Inline)]
        public AsmOperationCode(byte b0)
        {
            Data = v8u(vparts(w128, (ulong)b0,0ul));
        }
    }

    public readonly struct AsmOperationKey
    {
        readonly ulong Data;
    }


    public readonly struct AsmOpCode
    {

    }
}