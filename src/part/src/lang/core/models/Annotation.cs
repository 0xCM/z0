//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Annotation
    {
        public TextBlock Content {get;}

        public ulong Kind {get;}

        [MethodImpl(Inline)]
        public Annotation(string content, ulong kind)
        {
            Content = content;
            Kind = kind;
        }
    }
}