//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct IntelSdm
    {
        public readonly struct TableCell
        {
            public string Content {get;}

            [MethodImpl(Inline)]
            public TableCell(string content)
            {
                Content = content;
            }
        }
    }
}