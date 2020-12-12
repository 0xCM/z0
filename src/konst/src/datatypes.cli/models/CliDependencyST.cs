//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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

        [MethodImpl(Inline)]
        public static implicit operator CliDependency<S,T>((S src, T dst) x)
            => new CliDependency<S,T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator CliDependency<S,T>(in Paired<S,T> x)
            => new CliDependency<S,T>(x.Left, x.Right);
    }
}