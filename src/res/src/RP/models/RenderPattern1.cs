//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    public readonly struct RenderPattern<T> : IRenderPattern<RenderPattern<T>,T>
    {
        public string PatternText {get;}

        [MethodImpl(Inline)]
        public RenderPattern(string src)
            => PatternText = src;

        [MethodImpl(Inline)]
        public string Format(in T src)
            => string.Format(PatternText, src);

        [MethodImpl(Inline)]
        public RenderCapture Capture(in T src)
            => RP.capture(this, src);

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<T>(string src)
            => new RenderPattern<T>(src);
    }
}