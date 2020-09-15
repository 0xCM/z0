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
    /// Defines an encoded instruction
    /// </summary>
    public struct AsmStatementEncoding
    {
        public uint Sequence;

        public AsmStatement Source;

        public AsmSpecifier OpCode;

        public EncodedFx Encoded;

        [MethodImpl(Inline)]
        public AsmStatementEncoding(uint seq, AsmStatement statement, AsmSpecifier code, EncodedFx encoded)
        {
            Sequence = seq;
            Source = statement;
            OpCode = code;
            Encoded = encoded;
        }
    }
}