//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static AsciCharText;

    partial struct RenderPatterns
    {
        [StringLiteral(Dash2, 1)]
        public const string Dash1 = Dash;

        [StringLiteral(Dash2, 2)]
        public const string Dash2 = Dash1 + Dash1;

        [StringLiteral(Dash3, 3)]
        public const string Dash3 = Dash2 + Dash1;

        [StringLiteral(Dash4, 4)]
        public const string Dash4 = Dash3 + Dash1;

        [StringLiteral(Dash5, 5)]
        public const string Dash5 = Dash4 + Dash1;

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        [StringLiteral(Dash40, 40)]
        public const string Dash40 = "----------------------------------------";

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        [StringLiteral(Dash80, 80)]
        public const string Dash80 = Dash40 + Dash40;

        /// <summary>
        /// Delimiter between total/segment widths of a segmented type
        /// </summary>
        [StringLiteral(SegSep)]
        public const string SegSep = x;

        /// <summary>
        /// Pluralizes something
        /// </summary>
        [StringLiteral(Plural,1)]
        public const string Plural = s;

        /// <summary>
        /// Suffix used to pluralize a possessive
        /// </summary>
        [StringLiteral(PluralPosses)]
        public const string PluralPosses = "'s";

        /// <summary>
        /// Defines the default field delimiter
        /// </summary>
        [StringLiteral(FieldSep, 3)]
        public const string FieldSep = " | ";

        /// <summary>
        /// Defines the literal '|'
        /// </summary>
        [StringLiteral(Pipe, 1)]
        public const string Pipe = "|";

        /// <summary>
        /// Defines the literal '.'
        /// </summary>
        [StringLiteral(Dot, 1)]
        public const string Dot = ".";

        /// <summary>
        /// Defines the default extension delimiter
        /// </summary>
        [StringLiteral(ExtSep)]
        public const string ExtSep = Dot;

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

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        [StringLiteral(DataExt)]
        public const string DataExt = "csv";
    }
}