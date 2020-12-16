//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiCodeBlocks
    {
        public Index<ApiCodeBlock> Code {get;}

        [MethodImpl(Inline)]
        public ApiCodeBlocks(ApiCodeBlock[] code)
            => Code = code;

        [MethodImpl(Inline)]
        public static implicit operator ApiCodeBlocks(ApiCodeBlock[] src)
            => new ApiCodeBlocks(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiCodeBlock[](ApiCodeBlocks src)
            => src.Code;
    }
}