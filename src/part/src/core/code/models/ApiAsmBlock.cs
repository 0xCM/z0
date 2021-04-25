//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiAsmBlock : IApiSourceBlock<ApiAsmBlock, AsmSourceBlock>
    {
        public ApiToken Id {get;}

        public AsmSourceBlock SourceCode {get;}

        [MethodImpl(Inline)]
        public ApiAsmBlock(ApiToken id, AsmSourceBlock src)
        {
            Id = id;
            SourceCode = src;
        }
    }
}