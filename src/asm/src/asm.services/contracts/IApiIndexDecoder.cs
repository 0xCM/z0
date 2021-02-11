//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    public interface IApiIndexDecoder : IWfService
    {
        ApiAsmDataset Decode(ApiCodeBlocks src);

        ApiHostRoutines Decode(ApiHostCode src);
    }
}