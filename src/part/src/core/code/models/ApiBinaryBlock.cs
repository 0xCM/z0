//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiBinaryBlock : IApiSourceBlock<ApiBinaryBlock, BinarySourceBlock>
    {
        public ApiToken Id {get;}

        public BinarySourceBlock SourceCode {get;}

        [MethodImpl(Inline)]
        public ApiBinaryBlock(ApiToken id, BinarySourceBlock src)
        {
            Id = id;
            SourceCode = src;
        }
    }
}