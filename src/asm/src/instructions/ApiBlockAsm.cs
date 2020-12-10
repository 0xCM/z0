//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Encapsulates a contiguous instruction sequence along with the captured bits
    /// </summary>
    public readonly struct ApiBlockAsm
    {
        /// <summary>
        /// Encoded assembly
        /// </summary>
        public ApiCodeBlock Encoded {get;}

        /// <summary>
        /// The decoded instructions
        /// </summary>
        public Instruction[] Decoded {get;}

        /// <summary>
        /// The reason capture was terminated
        /// </summary>
        public ExtractTermCode TermCode {get;}

        [MethodImpl(Inline)]
        public ApiBlockAsm(ApiCodeBlock encoded, Instruction[] decoded, ExtractTermCode term)
        {
            Encoded = encoded;
            Decoded = decoded;
            TermCode = term;
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Encoded.Base;
        }

        /// <summary>
        /// Queries/Manipulates an index-identified instruction
        /// </summary>
        public ref Instruction this[int i]
            => ref Decoded[i];

        public int InstructionCount
            => Decoded.Length;
    }
}