//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmDocs
    {
        readonly Index<AsmDoc> Data;

        [MethodImpl(Inline)]
        public AsmDocs(AsmDoc[] src)
        {
            Data = src;
        }

        public AsmDoc[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmDocs(AsmDoc[] src)
            => new AsmDocs(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmDoc[](AsmDocs src)
            => src.Data;
    }
}