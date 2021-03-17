//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IApiIndexDecoder : IWfService
    {
        ApiAsmDataset Decode(ApiCodeBlocks src);

        ApiHostRoutines Decode(ApiHostCode src);
    }
}