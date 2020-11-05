//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolFlags<F> : ITextual
        where F : unmanaged
    {
        public readonly F[] Supported;

        [MethodImpl(Inline)]
        public ToolFlags(F[] flags)
            => Supported = flags;

        public ref readonly F this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Supported[index];
        }

        public string Format()
            => Supported.Format();
    }
}