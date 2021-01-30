//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmEncoding
    {
        public AsmStatement Statement {get;}

        public AsmInstructionSpecExprLegacy Specifier {get;}

        public BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public AsmEncoding(AsmStatement statement, AsmInstructionSpecExprLegacy specifier, BinaryCode encoded)
        {
            Specifier = specifier;
            Statement = statement;
            Encoded = encoded;
        }

        public bool Equals(AsmEncoding src)
            => Statement.Equals(src.Statement)
            && Specifier.Equals(src.Specifier)
            && Encoded.Equals(src.Encoded);

        public int CompareTo(AsmEncoding src)
            => Statement.CompareTo(src.Statement);
    }
}