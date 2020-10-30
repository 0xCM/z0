//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static AsciCharText;

    partial struct RP
    {
        /// <summary>
        /// Defines the literal '('
        /// </summary>
        [StringLiteral(OpenTuple)]
        public const string OpenTuple = "(";

        /// <summary>
        /// Defines the literal ')'
        /// </summary>
        [StringLiteral(CloseTuple)]
        public const string CloseTuple = ")";

        [FormatPattern(1, Tuple1)]
        public const string Tuple1 = OpenTuple + Slot0 + CloseTuple;

        [FormatPattern(2, Tuple2)]
        public const string Tuple2 = "({0}, {1})";

        [FormatPattern(3, Tuple3)]
        public const string Tuple3 = "({0}, {1}, {2})";

        [FormatPattern(4, Tuple4)]
        public const string Tuple4 = "({0}, {1}, {2}, {3})";

        [FormatPattern(5, Tuple5)]
        public const string Tuple5 = "({0}, {1}, {2}, {3}, {4})";

        [FormatPattern(6, Tuple6)]
        public const string Tuple6 = "({0}, {1}, {2}, {3}, {4}, {5})";

        [FormatPattern(7, "({0}, {1}, {2}, {3}, {4}, {5}, {6})")]
        public const string Tuple7 = "({0}, {1}, {2}, {3}, {4}, {5}, {6})";
    }
}