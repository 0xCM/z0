//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmLabel : ITextual, INullity
    {
        AsmLabelKind Kind {get;}
    }

    public interface IAsmOffsetLabel : IAsmLabel
    {
        ulong Offset {get;}

        DataWidth Width {get;}

        AsmLabelKind IAsmLabel.Kind
            => AsmLabelKind.Offset;
    }

    public interface IAsmBlockLabel : IAsmLabel
    {
        Identifier Name {get;}

        AsmLabelKind IAsmLabel.Kind
            => AsmLabelKind.Block;
    }
}