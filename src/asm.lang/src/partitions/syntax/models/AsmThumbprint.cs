//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmThumbprint : IDataTypeComparable<AsmThumbprint>
    {
        TextBlock Content {get;}

        public AsmThumbprint(AsmStatementExpr statement, AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
            => Content = string.Format("{0,-32} ; ({1})[{2}]{3}{4}", statement, sig, opcode, Encoded, encoded);

        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Content.GetHashCode();

        public bool Equals(AsmThumbprint src)
            => src.Content.Equals(Content);

        public override bool Equals(object src)
            => src is AsmThumbprint t && Equals(t);

        public int CompareTo(AsmThumbprint src)
        {
            var e0 = Content.Format().LeftOfFirst(Encoded);
            var e1 = src.Content.Format().LeftOfFirst(Encoded);
            return e0.CompareTo(e1);
        }

        const string Encoded = " => ";
    }
}