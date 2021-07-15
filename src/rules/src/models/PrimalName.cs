//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct PrimalName
        {
            readonly ByteBlock16 Data;

            [MethodImpl(Inline)]
            public PrimalName(string src)
            {
                Data = ByteBlock16.Empty;
                AsciSymbols.encode(src, Data.Bytes);
            }
        }
    }
}