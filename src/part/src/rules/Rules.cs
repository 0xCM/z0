//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;


    [ApiHost]
    public readonly partial struct Rules
    {
        const NumericKind Closure = UnsignedInts;


        [Op, Closures(Closure)]
        public static string format<A>(Antecedant<A> src)
            where A : IEquatable<A>
                => string.Format("({0}):{1}", src.Terms.Delimit(Chars.Amp),  typeof(A).Name);
    }

    partial struct Msg
    {
        static RenderPattern<S,Type> TransformFailedPattern<S>()
            => "The transformation {0}->{1} failed";

        public static string TransformFailed<S,T>(S src)
            => TransformFailedPattern<S>().Format(src, typeof(T));
    }
}