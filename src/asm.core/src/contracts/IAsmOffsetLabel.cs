//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmOffsetLabel : IAsmLineToken
    {
        ulong OffsetValue {get;}

        byte OffsetWidth {get;}
    }
}