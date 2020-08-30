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
    using static z;

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
}