//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct Tag<K> : IRule<Tag<K>,K>
            where K : unmanaged
        {
            public string Content {get;}

            public K Kind {get;}

            [MethodImpl(Inline)]
            public Tag(string content, K kind)
            {
                Content = content;
                Kind = kind;
            }
        }
    }
}