//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    using API = Commands;

    /// <summary>
    /// Defines an encoded instruction
    /// </summary>
    public readonly struct AsmCommand : IAsmCommand<AsmCommand>
    {        
        public readonly int Index;

        readonly string BodyText;

        readonly string OpCodeText;

        readonly string InstructionText;

        readonly EncodedCommand encoded;

        [MethodImpl(Inline)]
        internal AsmCommand(int index, string asm, string opcode, string instruction, EncodedCommand encoded)
        {
            this.Index = index;
            this.BodyText = asm;
            this.OpCodeText = opcode;
            this.InstructionText = instruction;
            this.encoded = encoded;
        }
        
        public ReadOnlySpan<char> Body
        {
            [MethodImpl(Inline)]
            get => BodyText;
        }

        public ReadOnlySpan<char> OpCode
        {
            [MethodImpl(Inline)]
            get => OpCodeText;
        }

        public ReadOnlySpan<char> Instruction
        {
            [MethodImpl(Inline)]
            get => InstructionText;
        }

        public ReadOnlySpan<byte> Encoding
        {
            [MethodImpl(Inline)]
            get => encoded.Encoding;
        }

        public byte EncodingSize
        {
            [MethodImpl(Inline)]
            get => encoded.EncodingSize;
        }
    }
}