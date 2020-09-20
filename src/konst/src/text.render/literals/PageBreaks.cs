//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct RenderPatterns
    {
        [StringLiteral(PageBreak5, 5)]
        public const string PageBreak5 = Dash5;

        [StringLiteral(PageBreak10, 10)]
        public const string PageBreak10 = PageBreak5 + PageBreak5;

        [StringLiteral(PageBreak20, 20)]
        public const string PageBreak20 = PageBreak10 + PageBreak10;

        [StringLiteral(PageBreak40)]
        public const string PageBreak40 = PageBreak20 + PageBreak20;

        [StringLiteral(PageBreak80, 80)]
        public const string PageBreak80 = PageBreak40 + PageBreak40;

        [StringLiteral(PageBreak120, 120)]
        public const string PageBreak120 = PageBreak80 + PageBreak40;

        [StringLiteral(PageBreak160, 160)]
        public const string PageBreak160 = PageBreak80 + PageBreak80;
    }
}