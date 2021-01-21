//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiAsmLine
    {
        public Address16 Offset {get;}

        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public ApiAsmLine(Address16 offset, TextBlock content)
        {
            Offset = offset;
            Content = content;
        }
    }
}