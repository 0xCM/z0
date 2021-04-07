//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Xed;

    [Record(TableId)]
    public struct XedFormExport : IRecord<XedFormExport>
    {
        public const string TableId = "xed.forms.export";

        public ushort Index;

        public IForm Identifier;

        public AsmMnemonic Mnemonic;

        public DelimitedIndex<AttributeKind> Attributes;

        public IsaKind IsaKind;

        public Extension Extension;
    }

}