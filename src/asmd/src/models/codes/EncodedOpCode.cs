//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct EncodedOpCode
    {        
        public static EncodedOpCode Empty 
            => new EncodedOpCode(OpCodeSpec.Empty, InstructionSpec.Empty, Control.array<byte>());
            
        readonly InstructionSpec Instruction;

        readonly OpCodeSpec Code;

        public readonly byte[] Encoding;

        [MethodImpl(Inline)]
        public EncodedOpCode(OpCodeSpec code, InstructionSpec instruction, byte[] encoding)
        {
            this.Code = code;
            this.Instruction = instruction;
            this.Encoding = encoding;
        }

        [MethodImpl(Inline)]
        public EncodedOpCode Update(OpCodeSpec code, InstructionSpec instruction, byte[] encoding)
            => new EncodedOpCode(code,instruction,encoding);
    }
}