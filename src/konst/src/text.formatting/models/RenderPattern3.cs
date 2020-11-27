//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RenderPattern<A0,A1,A2> : IRenderPattern<RenderPattern<A0,A1,A2>,A0,A1,A2>
    {
        public string PatternText {get;}

        [MethodImpl(Inline)]
        public RenderPattern(string src)
            => PatternText = src;

        [MethodImpl(Inline)]
        public string Apply(in A0 a0, in A1 a1, in A2 a2)
            => text.format(PatternText, a0, a1, a2);

        [MethodImpl(Inline)]
        public RenderCapture Capture(in A0 a0, in A1 a1, in A2 a2)
            => Render.capture(this, a0, a1, a2);

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<A0,A1,A2>(string src)
            => new RenderPattern<A0,A1,A2>(src);
    }
}