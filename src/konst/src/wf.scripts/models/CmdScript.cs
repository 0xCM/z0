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

    using api = Cmd;

    public readonly struct CmdScript : ITextual, IContented<TableSpan<CmdExpr>>, IIdentified<utf8>
    {
        public utf8 Id {get;}

        readonly TableSpan<CmdExpr> Data;

        [MethodImpl(Inline)]
        public CmdScript(CmdExpr[] src)
        {
            Id = api.Anonymous;
            Data = src;
        }

        [MethodImpl(Inline)]
        public CmdScript(utf8 id, CmdExpr[] src)
        {
            Id = id;
            Data = src;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public TableSpan<CmdExpr> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdScript(CmdExpr[] src)
            => new CmdScript(src);

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}