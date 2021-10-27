//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    [LiteralProvider]
    public readonly struct Composers
    {
        /// <summary>
        /// The signed specifier
        /// </summary>
        public const string i = "u";

        /// <summary>
        /// The unsigned specifier
        /// </summary>
        public const string u = "u";

        /// <summary>
        /// The floating-point specifier
        /// </summary>
        public const string f = "f";

        /// <summary>
        /// The vector specifier
        /// </summary>
        public const string v = "v";

        /// <summary>
        /// The product specifier
        /// </summary>
        public const string x = "x";

        /// <summary>
        /// The sum specifier
        /// </summary>
        public const string or = "|";

        /// <summary>
        /// The seqence specifier
        /// </summary>
        public const string seq = "*";

        /// <summary>
        /// The left grouping/containment specifier
        /// </summary>
        public const string left = "(";

        /// <summary>
        /// The right grouping/containment specifier
        /// </summary>
        public const string right = ")";

    }
}