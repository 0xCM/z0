//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    public interface IAsmHexWriter : IAsmStreamWriter
    {
        void Write(in AsmOpData src, int? uripad = null);

        void Write(AsmOpData[] src);
    }
}
