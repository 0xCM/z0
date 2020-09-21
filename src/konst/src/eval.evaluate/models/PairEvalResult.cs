//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PairEvalResult<T>
    {
        public readonly Pair<ArtifactIdentifier> Source;

        public readonly Pair<T> Target;

        [MethodImpl(Inline)]
        public PairEvalResult(Pair<ArtifactIdentifier> src, Pair<T> dst)
        {
            Source = src;
            Target = dst;
        }
    }
}