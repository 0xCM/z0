//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IApiIndexDecoder
    {
        ApiAsmDataset Decode(ApiBlockIndex src);

        ApiHostRoutines Decode(ApiHostCode src);
    }
}