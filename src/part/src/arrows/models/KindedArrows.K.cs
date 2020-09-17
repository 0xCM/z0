//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct KindedArrows<K>
    {
        public readonly K Source;

        public readonly K[] Targets;

        [MethodImpl(Inline)]
        public KindedArrows(K client, K[] src)
        {
            Source = client;
            Targets = src;
        }
    }
}