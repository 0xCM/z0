//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;


    public readonly struct Annotation<K>
        where K : unmanaged
    {
        public TextBlock Content {get;}

        public K Kind {get;}

        [MethodImpl(Inline)]
        public Annotation(string content, K kind)
        {
            Content = content;
            Kind = kind;
        }
    }
}