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
        public readonly struct Annotation : IRule<Annotation>
        {
            public string Content {get;}

            public ulong Kind {get;}

            [MethodImpl(Inline)]
            public Annotation(string content, ulong kind)
            {
                Content = content;
                Kind = kind;
            }
        }

        public readonly struct Annotation<K> : IRule<Annotation<K>,K>
            where K : unmanaged
        {
            public string Content {get;}

            public K Kind {get;}

            [MethodImpl(Inline)]
            public Annotation(string content, K kind)
            {
                Content = content;
                Kind = kind;
            }
        }
    }
}