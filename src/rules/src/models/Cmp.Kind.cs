//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using S = CmpSymbol;

    public enum CmpKind : byte
    {
        [Symbol(S.EQ)]
        EQ,

        [Symbol(S.LT)]
        LT,

        [Symbol(S.LE)]
        LE,

        [Symbol(S.NEQ)]
        NEQ,

        [Symbol(S.NLT)]
        NLT,

        [Symbol(S.NGT)]
        NGT,

        [Symbol(S.GT)]
        GT,

        [Symbol(S.GE)]
        GE
    }

    [ApiComplete("cmp.symbol")]
    public readonly struct CmpSymbol
    {
        public const string EQ = "==";

        public const string NEQ = "!=";

        public const string GT = ">";

        public const string NGT = "!>";

        public const string GE = ">=";

        public const string LT = "<";

        public const string LE = "<=";

        public const string NLT = "!<";
    }
}