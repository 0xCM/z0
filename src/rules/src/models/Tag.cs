//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct Tag : IRule<Tag>
        {
            public string Content {get;}

            public ulong Kind {get;}

            [MethodImpl(Inline)]
            public Tag(string content, ulong kind)
            {
                Content = content;
                Kind = kind;
            }
        }
    }
}