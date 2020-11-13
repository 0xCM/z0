//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a directed association from one artifact to another
    /// </summary>
    public readonly struct CliDependency
    {
        public ClrArtifactKey Source {get;}

        public ClrArtifactKey Target {get;}

        [MethodImpl(Inline)]
        public CliDependency(ClrArtifactKey src, ClrArtifactKey dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator CliDependency((ClrArtifactKey src, ClrArtifactKey dst) x)
            => new CliDependency(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator Pair<ClrArtifactKey>(CliDependency r)
            =>  z.pair(r.Source, r.Target);
    }

    public readonly struct CliDependency<S,T>
        where S : struct
        where T : struct
    {
        public S Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public CliDependency(S src, T dst)
        {
            Source = src;
            Target = dst;
        }
    }
}