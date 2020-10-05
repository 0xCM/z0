//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    public readonly struct HexDoc : IArchiveDoc<HexDoc,utf8,utf8>
    {
        public utf8 Id {get;}

        public utf8 Content {get;}

        [MethodImpl(Inline)]
        public HexDoc(utf8 name, utf8 src)
        {
            Id = name;
            Content = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator HexDoc(Pair<utf8> src)
            => new HexDoc(src.Left, src.Right);

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();
    }
}