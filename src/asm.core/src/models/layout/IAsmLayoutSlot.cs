//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmLayoutSlot
    {
        AsmLayoutPart Kind {get;}

        byte Position {get;}
    }
}