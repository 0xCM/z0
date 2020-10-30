//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct CmdData : ITextual
    {
        public CmdId CmdId {get;}

        public utf8 Content {get;}

        [MethodImpl(Inline)]
        public CmdData(CmdId id, utf8 data)
        {
            CmdId = id;
            Content = data;
        }

        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdData((CmdId id, string data) src)
            => new CmdData(src.id, src.data);

        [MethodImpl(Inline)]
        public static implicit operator CmdData((CmdId id, utf8 data) src)
            => new CmdData(src.id, src.data);

        [MethodImpl(Inline)]
        public static implicit operator CmdData((CmdId id, char[] data) src)
            => new CmdData(src.id, src.data);

        [MethodImpl(Inline)]
        public static implicit operator CmdData((CmdId id, byte[] data) src)
            => new CmdData(src.id, src.data);
    }
}