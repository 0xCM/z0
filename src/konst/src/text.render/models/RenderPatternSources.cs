//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RenderPatternSources
    {
        readonly TableSpan<RenderPatternSource> Data;

        [MethodImpl(Inline)]
        public static implicit operator RenderPatternSources(RenderPatternSource[] src)
            => new RenderPatternSources(src);

        [MethodImpl(Inline)]
        public RenderPatternSources(RenderPatternSource[] src)
            => Data = src;

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<RenderPatternSource> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref readonly RenderPatternSource this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}