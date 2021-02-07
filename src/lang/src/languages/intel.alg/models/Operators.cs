//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using K = IntelAlgorithms.OperatorKind;
    using S = IntelAlgorithms.OperatorSymbols;

    partial struct IntelAlgorithms
    {
        public readonly struct Operators
        {
            public static Operator Assign => op(S.Assign, K.Assign);

            public static Operator Not => op(S.Not, K.Not);

            public static Operator And => op(S.And, K.And);

            public static Operator Gt => op(S.Gt, K.Gt);

            public static Operator GtEq => op(S.GtEq, K.GtEq);

            public static Operator Lt => op(S.Lt, K.Lt);

            public static Operator LtEq => op(S.LtEq, K.LtEq);
        }

        public readonly struct OperatorSymbols
        {
            public const string Assign = ":=";

            public const string Not = "NOT";

            public const string And = "AND";

            public const string Eq = "==";

            public const string Add = "+";

            public const string Sub = "-";

            public const string Gt = ">";

            public const string Lt = "<";

            public const string GtEq = ">=";

            public const string LtEq = "<=";
        }

        public enum OperatorKind : byte
        {
            None = 0,

            Not,

            And,

            Assign,

            Add,

            Sub,

            Eq,

            Neq,

            Gt,

            GtEq,

            Lt,

            LtEq,
        }
    }
}