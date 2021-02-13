//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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

}