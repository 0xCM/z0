//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost("lang.api")]
    public readonly partial struct lang
    {
        const Z0.NumericKind Closure = Z0.NumericKind.Unsigned;

    }

    partial struct Msg
    {
        static RenderPattern<S,Type> TransformFailedPattern<S>()
            => "The transformation {0}->{1} failed";

        public static string TransformFailed<S,T>(S src)
            => TransformFailedPattern<S>().Format(src, typeof(T));
    }
}