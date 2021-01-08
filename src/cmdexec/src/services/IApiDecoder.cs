//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public interface IApiDecoder : IWfService
    {
        ApiHostRoutines DecodeBlocks(in ApiHostCode src);

        Span<ApiPartRoutines> DecodeIndex(ApiCodeBlockIndex index);
    }
}