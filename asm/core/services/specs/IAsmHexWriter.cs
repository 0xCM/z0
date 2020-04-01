//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    public interface IAsmHexWriter : IAsmStreamWriter
    {
        void Write(in AsmOpBits src, int? uripad = null);

        void Write(AsmOpBits[] src);
    }
}
