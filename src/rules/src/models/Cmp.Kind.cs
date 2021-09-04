//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using S = CmpSymbol;

    public enum CmpKind : byte
    {
        [Op(S.EQ)]
        EQ,

        [Op(S.LT)]
        LT,

        [Op(S.LE)]
        LE,

        [Op(S.NEQ)]
        NEQ,

        [Op(S.NLT)]
        NLT,

        [Op(S.NGT)]
        NGT,

        [Op(S.GT)]
        GT,

        [Op(S.GE)]
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