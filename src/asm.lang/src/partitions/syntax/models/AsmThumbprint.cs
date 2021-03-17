//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmThumbprint : IDataTypeComparable<AsmThumbprint>
    {
        TextBlock Content {get;}

        public AsmThumbprint(AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode encoded)
            => Content = string.Format("({0})[{1}]{2}{3}", sig, opcode, Implication, encoded);

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
            var e0 = Content.Format().LeftOfFirst(Implication);
            var e1 = src.Content.Format().LeftOfFirst(Implication);
            return e0.CompareTo(e1);
        }

        const string Implication = " => ";
    }
}