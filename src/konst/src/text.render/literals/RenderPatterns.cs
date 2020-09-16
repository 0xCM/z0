//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static AsciCharText;

    [LiteralProvider]
    public readonly partial struct RenderPatterns
    {
        /// <summary>
        /// Defines the literal '"{1}"'
        /// </summary>
        public const string QSlot1 = OpenQSlot + D1 + CloseQSlot;

        /// <summary>
        /// Defines the literal '"{2}"'
        /// </summary>
        public const string QSlot2 = OpenQSlot + D2 + CloseQSlot;

        /// <summary>
        /// Defines the literal '"{3}"'
        /// </summary>
        public const string QSlot3 = OpenQSlot + D3 + CloseQSlot;

        /// <summary>
        /// Defines the literal '"{4}"'
        /// </summary>
        public const string QSlot4 = OpenQSlot + D4 + CloseQSlot;

        [FormatPattern("{0} ")]
        public const string RSpace = "{0} ";

        [FormatPattern(" {0}")]
        public const string LSpace = " {0}";

        /// <summary>
        /// Defines the literal " |"
        /// </summary>
        [StringLiteral(" |")]
        public const string SpacePipe = Space + Pipe;


        /// <summary>
        /// Defines the literal '{0} -> {1}'
        /// </summary>
        [FormatPattern("{0} -> {1}")]
        public const string ArrowAxB = "{0} -> {1}";

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