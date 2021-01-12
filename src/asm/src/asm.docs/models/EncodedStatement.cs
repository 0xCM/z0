//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDocParts
    {
        public readonly struct EncodedStatement
        {
            public BinaryCode Content {get;}

            public PartKind Kind
                => PartKind.StatementEncoding;

            [MethodImpl(Inline)]
            public EncodedStatement(byte[] data)
                => Content = data;
        }
    }
}