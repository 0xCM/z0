//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Label<K> : ILabel<K>
        where K : unmanaged
    {
        public K Kind {get;}

        public string Content {get;}


        [MethodImpl(Inline)]
        public Label(K kind, string content)
        {
            Kind = kind;
            Content = content;
        }

        public string Format()
            => string.Format("{0}:{1}", Kind, Content);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator string(Label<K> src)
            => src.Content;
    }
}