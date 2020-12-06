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
        public CliArtifactKey Source {get;}

        public CliArtifactKey Target {get;}

        [MethodImpl(Inline)]
        public CliDependency(CliArtifactKey src, CliArtifactKey dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator CliDependency((CliArtifactKey src, CliArtifactKey dst) x)
            => new CliDependency(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator Pair<CliArtifactKey>(CliDependency r)
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