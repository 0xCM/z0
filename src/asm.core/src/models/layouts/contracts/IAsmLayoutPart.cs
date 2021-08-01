//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmLayouts;

    public interface IAsmLayoutPart
    {
        SlotKind Kind {get;}
    }

    public interface IAsmLayoutPart<T> : IAsmLayoutPart
        where T : unmanaged, IAsmLayoutPart<T>
    {

    }
}