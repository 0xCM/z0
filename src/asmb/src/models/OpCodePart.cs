//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct OpCodePart
    {
        public readonly asci8 Content;

        [MethodImpl(Inline)]
        public OpCodePart(asci8 src)
        {
            Content = src;
        }

        public string Format()
            => Content.Format();
    }
}