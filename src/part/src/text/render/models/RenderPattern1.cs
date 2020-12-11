//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RenderPattern<T> : IRenderPattern<RenderPattern<T>,T>
    {
        public string PatternText {get;}

        [MethodImpl(Inline)]
        public RenderPattern(string src)
            => PatternText = src;

        [MethodImpl(Inline)]
        public string Format(in T src)
            => text.format(PatternText, src);

        [MethodImpl(Inline)]
        public RenderCapture Capture(in T src)
            => RenderPatterns.capture(this, src);

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<T>(string src)
            => new RenderPattern<T>(src);
    }
}