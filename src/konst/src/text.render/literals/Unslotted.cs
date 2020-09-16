//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static AsciCharText;

    partial struct RenderPatterns
    {
        /// <summary>
        /// Pluralizes something
        /// </summary>
        [StringLiteral(Plural)]
        public const string Plural = "s";

        /// <summary>
        /// Suffix used to pluralize a possessive
        /// </summary>
        [StringLiteral(PluralPosses)]
        public const string PluralPosses = "'s";

        /// <summary>
        /// Defines the default field delimiter
        /// </summary>
        [StringLiteral(FieldSep)]
        public const string FieldSep = " | ";

        /// <summary>
        /// Defines the literal '->'
        /// </summary>
        [StringLiteral(Pipe)]
        public const string Pipe = "|";

        /// <summary>
        /// Defines the literal '.'
        /// </summary>
        [StringLiteral(Dot)]
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

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        public const string Dash40 = "----------------------------------------";

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        [StringLiteral("--------------------------------------------------------------------------------")]
        public const string Dash80 = Dash40 + Dash40;

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        [StringLiteral("------------------------------------------------------------------------------------------------------------------------")]
        public const string Dash120 = Dash80 + Dash40;

        /// <summary>
        /// Defines the default extension for structured data
        /// </summary>
        [StringLiteral("----------------------------------------------------------------------------------------------------------------------------------------------------------------")]
        public const string Dash160 = Dash80 + Dash80;

        /// <summary>
        /// Defines the literal '{'
        /// </summary>
        [StringLiteral("{")]
        public const string OpenSlot = LBrace;

        /// <summary>
        /// Defines the literal '}'
        /// </summary>
        [StringLiteral("}")]
        public const string CloseSlot = RBrace;

        /// <summary>
        /// Defines the literal '"{'
        /// </summary>
        [StringLiteral("\"{")]
        public const string OpenQSlot = DQuote + LBrace;

        /// <summary>
        /// Defines the literal '"}'
        /// </summary>
        [StringLiteral("\"}")]
        public const string CloseQSlot = RBrace + DQuote;

        /// <summary>
        /// Defines the literal '"{0}"'
        /// </summary>
        [StringLiteral("\"{\"}")]
        public const string QSlot0 = OpenQSlot + D0 + CloseQSlot;

        [StringLiteral(PageBreak20)]
        public const string PageBreak10 = "----------";

        [StringLiteral(PageBreak20)]
        public const string PageBreak20 = PageBreak10 + PageBreak10;

        [StringLiteral(PageBreak40)]
        public const string PageBreak40 = PageBreak20 + PageBreak20;

        [StringLiteral(PageBreak80)]
        public const string PageBreak80 = PageBreak40 + PageBreak40;

        [StringLiteral(PageBreak120)]
        public const string PageBreak120 = PageBreak80 + PageBreak40;

        [StringLiteral(PageBreak160)]
        public const string PageBreak160 = PageBreak80 + PageBreak80;
    }
}