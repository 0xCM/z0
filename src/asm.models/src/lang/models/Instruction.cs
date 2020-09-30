//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmLang
    {
        /// <summary>
        /// Represents a keyword in the asm grammar
        /// </summary>
        public readonly struct Instruction : ISyntaxAtom<Instruction,InstructionCode>
        {
            public InstructionCode Code {get;}

            [MethodImpl(Inline)]
            public Instruction(InstructionCode key)
                => Code = key;

            [MethodImpl(Inline)]
            public static implicit operator Instruction(InstructionCode src)
                => new Instruction(src);

            [MethodImpl(Inline)]
            public static implicit operator InstructionCode(Instruction src)
                => src.Code;
        }
    }
}