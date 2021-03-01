//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using F = XedSummaryField;
    using R = XedSummaryRow;

    [Record(TableId)]
    public struct XedSummaryRow : ITabular<F,R>
    {
        public const string TableId = "xed.summary";

        public TextBlock Class;

        public TextBlock Category;

        public TextBlock Extension;

        public TextBlock IsaSet;

        public TextBlock IForm;

        public BinaryCode BaseCode;

        public TextBlock Mod;

        public TextBlock Reg;

        public TextBlock Pattern;

        public TextBlock Operands;

        public string DelimitedText(char sep)
            => Xed.format(this, sep);
    }
}