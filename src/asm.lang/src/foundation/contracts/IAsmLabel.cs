//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmLabel : ITextual, INullity
    {
        Identifier Name {get;}

    }

    public interface IAsmOffsetLabel : IAsmLabel
    {
        ulong Offset {get;}

        DataWidth Width {get;}
    }
}