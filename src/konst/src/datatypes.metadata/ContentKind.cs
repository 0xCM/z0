//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ContentKind : IContentKind
    {
        public MimeType BasicType {get;}

        [MethodImpl(Inline)]
        public ContentKind(MimeType mime)
        {
            BasicType = mime;
        }

        public string Format()
            => BasicType.Format();

        public override string ToString()
            => Format();
    }
}