//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct ConditionCodes
    {
        [LiteralProvider]
        public readonly struct ConditionExpressions
        {
            public const string O = "(OF=1)";

            public const string NO = "(OF=0)";

            /// <summary>
            /// Carry
            /// </summary>
            public const string C = "(CF=1)";

            /// <summary>
            /// No carry
            /// </summary>
            public const string NC = "(CF=0)";

            /// <summary>
            /// Zero
            /// </summary>
            public const string Z = "(ZF=1)";

            /// <summary>
            /// Nonzero
            /// </summary>
            public const string NZ = "(ZF=0)";

            /// <summary>
            /// Not Above
            /// </summary>
            public const string NA = "(CF=1 | ZF=1)";

            /// <summary>
            /// Above
            /// </summary>
            public const string A = "(CF=0 & ZF=0)";

            /// <summary>
            /// Sign
            /// </summary>
            public const string S = "(SF=1)";

            /// <summary>
            /// No Sign
            /// </summary>
            public const string NS = "(SF=0)";

            /// <summary>
            /// Parity
            /// </summary>
            public const string P = "(PF=1)";

            /// <summary>
            /// No Parity
            /// </summary>
            public const string NP = "(PF=0)";

            /// <summary>
            /// Not Greater
            /// </summary>
            public const string NG = "(ZF=1 | SF!=OF)";
        }
    }
}