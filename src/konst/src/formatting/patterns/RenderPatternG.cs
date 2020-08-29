//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct RenderPatterns
    {
        [MethodImpl(Inline)]
        public static RenderPattern<S0,S1> define<S0,S1>(string src)
            => src;

        [MethodImpl(Inline)]
        public static RenderPattern<S0,S1,S2> define<S0,S1,S2>(string src)
            => src;

        [MethodImpl(Inline)]
        public static RenderPattern<S0,S1,S2,S3> define<S0,S1,S2,S3>(string src)
            => src;

        [MethodImpl(Inline)]
        public static RenderPattern<S0,S1,S2,S3,S4> define<S0,S1,S2,S3,S4>(string src)
            => src;
    }

    public readonly struct RenderPattern<S0,S1>
    {
        readonly string Content;

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<S0,S1>(string src)
            => new RenderPattern<S0,S1>(src);

        [MethodImpl(Inline)]
        public RenderPattern(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format(S0 s0, S1 s1)
            => text.format(Content, s0, s1);
    }

    public readonly struct RenderPattern<S0,S1,S2>
    {
        readonly string Content;

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<S0,S1,S2>(string src)
            => new RenderPattern<S0,S1,S2>(src);

        [MethodImpl(Inline)]
        public RenderPattern(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format(S0 s0, S1 s1, S2 s2)
            => text.format(Content, s0, s1, s2);
    }

    public readonly struct RenderPattern<S0,S1,S2,S3>
    {
        readonly string Content;

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<S0,S1,S2,S3>(string src)
            => new RenderPattern<S0,S1,S2,S3>(src);

        [MethodImpl(Inline)]
        public RenderPattern(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format(S0 s0, S1 s1, S2 s2, S3 s3)
            => text.format(Content, s0, s1, s2, s3);
    }

    public readonly struct RenderPattern<S0,S1,S2,S3,S4>
    {
        readonly string Content;

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<S0,S1,S2,S3,S4>(string src)
            => new RenderPattern<S0,S1,S2,S3,S4>(src);

        [MethodImpl(Inline)]
        public RenderPattern(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format(S0 s0, S1 s1, S2 s2, S3 s3, S4 s4)
            => text.format(Content, s0, s1, s2, s3, s4);
    }
}