//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Name<S,T> : IName<Name<S,T>,S,T>
    {
        /// <summary>
        /// The <see cref='Target'/> name
        /// </summary>
        public readonly S Source;

        /// <summary>
        /// The named thing
        /// </summary>
        public readonly T Target;

        [MethodImpl(Inline)]
        public static implicit operator Name(Name<S,T> src)
            => new Name(src.Format());

        [MethodImpl(Inline)]
        public Name(S src, T dst)
        {
            Target = dst;
            Source = src;
        }

        S IDataFlow<S,T>.Source
             => Source;

        T IDataFlow<S,T>.Target
            => Target;

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(Source);

        [MethodImpl(Inline)]
        public static implicit operator Name<S,T>((S src, T dst) x)
            => new Name<S,T>(x.src, x.dst);
    }
}