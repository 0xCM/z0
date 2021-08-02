//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Blit;

    public struct map<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        public S Source;

        public T Target;

        [MethodImpl(Inline)]
        public map(S src, T dst)
        {
            Source =src;
            Target = dst;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public static implicit operator map<S,T>((S src, T dst) x)
            => new map<S,T>(x.src, x.dst);
    }

    public struct map<T>
        where T : unmanaged
    {
        public T Source;

        public T Target;

        [MethodImpl(Inline)]
        public map(T src, T dst)
        {
            Source =src;
            Target = dst;
        }

        public string Format()
            => api.format((map<T,T>)this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator map<T,T>(map<T> src)
            => new map<T,T>(src.Source, src.Target);

        [MethodImpl(Inline)]
        public static implicit operator map<T>(map<T,T> src)
            => new map<T>(src.Source, src.Target);
    }
}