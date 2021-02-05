//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    public interface IApiDecoder : IWfService
    {
        ApiHostRoutines DecodeRoutines(ApiHostCode src);

        Index<ApiPartRoutines> DecodeIndex(ApiCodeBlocks index);
    }
}