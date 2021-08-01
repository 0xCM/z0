//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmLayouts;

    public interface IAsmLayoutSlot
    {
        SlotKind Kind {get;}

        byte Position {get;}
    }
}