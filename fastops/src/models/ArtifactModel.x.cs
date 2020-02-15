//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
    using static SpanKind;

    public static class ArtifactModelX
    {

        [MethodImpl(Inline)]
        public static bool IsSome(this SpanKind kind)
            => kind != 0;

        [MethodImpl(Inline)]
        public static bool IsNone(this SpanKind kind)
            => kind == 0;

        public static string Format(this SpanKind kind)
            => kind.IsSome() ? (kind == Mutable ? IDI.Span : IDI.USpan) : string.Empty;

        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static MethodSig Signature(this MethodInfo src)
            => MethodSig.Define(src);

    }
}