//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct TextSpan
    {
        public TextBlock Text {get;}

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Text.View;
        }

        [MethodImpl(Inline)]
        public TextSpan(TextBlock src)
            => Text = src;
    }
}