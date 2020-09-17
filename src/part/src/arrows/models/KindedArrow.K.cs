//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct KindedArrow<K>
        where K : unmanaged, Enum
    {
        public readonly K Source;

        public readonly K Target;

        [MethodImpl(Inline)]
        public static implicit operator KindedArrow<K>((K client, K supplier) x)
            => new KindedArrow<K>(x.client,x.supplier);

        [MethodImpl(Inline)]
        public static implicit operator (K client, K supplier)(KindedArrow<K> x)
            => (x.Source, x.Target);

        [MethodImpl(Inline)]
        public KindedArrow(K src, K dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out K src, out K dst)
        {
            src = Source;
            dst = Target;
        }
    }
}