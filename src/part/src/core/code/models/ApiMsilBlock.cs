//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiMsilBlock : IApiSourceBlock<ApiMsilBlock, MsilSourceBlock>
    {
        public ApiToken Id {get;}

        public MsilSourceBlock SourceCode {get;}

        [MethodImpl(Inline)]
        public ApiMsilBlock(ApiToken id, MsilSourceBlock src)
        {
            Id = id;
            SourceCode = src;
        }
    }
}