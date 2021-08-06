//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Rules
    {
        [ApiComplete("cmp.symbol")]
        public readonly struct CmpSymbol
        {
            public static string EQ => "==";

            public static string NEQ => "!=";

            public static string GT => ">";

            public static string GTE => ">=";

            public static string LT => "<";

            public static string LTE => "<=";
        }
    }
}