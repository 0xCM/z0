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

    public readonly struct CmdScript : ICmdScript
    {
        public asci32 Id {get;}

        readonly TableSpan<CmdScriptExpr> Data;

        [MethodImpl(Inline)]
        public CmdScript(CmdScriptExpr[] src)
        {
            Id = api.Anonymous;
            Data = src;
        }

        [MethodImpl(Inline)]
        public CmdScript(asci32 id, CmdScriptExpr[] src)
        {
            Id = id;
            Data = src;
        }

        [MethodImpl(Inline)]
        public CmdScript(string id, CmdScriptExpr[] src)
        {
            Id = id;
            Data = src;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public TableSpan<CmdScriptExpr> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdScript(CmdScriptExpr[] src)
            => new CmdScript(src);

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}