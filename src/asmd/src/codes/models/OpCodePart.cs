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
        public readonly string Text;

        [MethodImpl(Inline)]
        public OpCodePart(string src)
        {
            Text = src;
        }

        public string Format()
            => Text;
    }
}