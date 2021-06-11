//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    public ref struct CharMap
    {
        public ReadOnlySpan<char> Output;

        public ref readonly char this[char c]
        {
            [MethodImpl(Inline)]
            get => ref skip(Output, (ushort)c);
        }
    }
}