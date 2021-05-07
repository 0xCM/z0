//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct MsgPattern<A0,A1> : IFormatPattern<MsgPattern<A0,A1>,A0,A1>, IMsgPattern
    {
        public string PatternText {get;}

        [MethodImpl(Inline)]
        public MsgPattern(string src)
            => PatternText= src;

        public string Format(in A0 a0, in A1 a1)
            => string.Format(PatternText, $"<{a0}>", $"<{a1}>");

        public RenderCapture Capture(in A0 a0, in A1 a1)
            => RP.capture(this, $"<{a0}>", $"<{a1}>");

        [MethodImpl(Inline)]
        public static implicit operator MsgPattern<A0,A1>(string src)
            => new MsgPattern<A0,A1>(src);
    }
}