//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a directed association from one artifact to another
    /// </summary>
    public readonly struct CliDependency
    {
        public readonly ClrArtifactKey Source;

        public readonly ClrArtifactKey Target;

        [MethodImpl(Inline)]
        public static implicit operator CliDependency((ClrArtifactKey src, ClrArtifactKey dst) x)
            => new CliDependency(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator Pair<ClrArtifactKey>(CliDependency r)
            =>  pair(r.Source, r.Target);

        [MethodImpl(Inline)]
        public CliDependency(ClrArtifactKey src, ClrArtifactKey dst)
        {
            Source = src;
            Target = dst;
        }
    }
}