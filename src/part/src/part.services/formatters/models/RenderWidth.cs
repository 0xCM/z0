//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RenderWidth : ITextual
    {
        public readonly byte Value;

        [MethodImpl(Inline)]
        public static implicit operator RenderWidth(int src)
            => new RenderWidth((byte)src);

        [MethodImpl(Inline)]
        public static implicit operator int(RenderWidth src)
            => src.Value;

        [MethodImpl(Inline)]
        public RenderWidth(byte value)
            => Value = value;

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();
    }
}