//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Defines the canonical option functor F:Option[A] -> Option[B] induced by a non-monadic dual f:A->B
        /// </summary>
        /// <param name="f">A non-monadic projector</param>
        /// <typeparam name="A">The source type</typeparam>
        /// <typeparam name="B">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Func<Option<A>,Option<B>> fmap<A,B>(Func<A,B> f)
            => x => x.TryMap(a => f(a));
    }
}