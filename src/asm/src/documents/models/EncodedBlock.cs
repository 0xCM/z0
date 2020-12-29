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
        public readonly struct EncodedBlock
        {
            public BinaryCode Content {get;}

            [MethodImpl(Inline)]
            public EncodedBlock(byte[] data)
                => Content = data;
        }
    }
}