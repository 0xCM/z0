//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Label<K>
        where K : unmanaged
    {
        public K Kind {get;}

        public Label Content {get;}

        [MethodImpl(Inline)]
        public Label(K kind, Label content)
        {
            Kind = kind;
            Content = content;
        }

        public string Format()
            => string.Format("{0}:{1}", Kind, Content);

        public override string ToString()
            => Format();
    }
}