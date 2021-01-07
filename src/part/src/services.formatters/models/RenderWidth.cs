//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    public readonly struct RenderWidth : ITextual
    {
        public ushort Value {get;}

        [MethodImpl(Inline)]
        public RenderWidth(ushort value)
            => Value = value;

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();

        [MethodImpl(Inline)]
        public static implicit operator RenderWidth(int src)
            => new RenderWidth((ushort)src);

        [MethodImpl(Inline)]
        public static implicit operator RenderWidth(ushort src)
            => new RenderWidth(src);

        [MethodImpl(Inline)]
        public static explicit operator short(RenderWidth src)
            => (short)src.Value;

        [MethodImpl(Inline)]
        public static implicit operator int(RenderWidth src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator RenderWidth<ushort>(RenderWidth src)
            => src.Value;
    }
}