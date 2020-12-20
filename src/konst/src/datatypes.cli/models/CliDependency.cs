//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    /// <summary>
    /// Defines a directed association from one artifact to another
    /// </summary>
    public readonly struct CliDependency
    {
        public CliKey Source {get;}

        public CliKey Target {get;}

        [MethodImpl(Inline)]
        public CliDependency(CliKey src, CliKey dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator CliDependency((CliKey src, CliKey dst) x)
            => new CliDependency(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator Pair<CliKey>(CliDependency r)
            =>  pair(r.Source, r.Target);
    }
}