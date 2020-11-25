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

    public readonly struct CmdScriptExpr : ICmdScriptExpr
    {
        public CmdPattern Pattern {get;}

        public CmdVarIndex Variables {get;}

        [MethodImpl(Inline)]
        public CmdScriptExpr(string pattern)
        {
            Pattern = pattern;
            Variables = CmdVars.init();
        }

        [MethodImpl(Inline)]
        internal CmdScriptExpr(CmdPattern pattern)
        {
            Pattern = pattern;
            Variables = CmdVars.init();
        }

        [MethodImpl(Inline)]
        internal CmdScriptExpr(CmdPattern pattern, CmdVarIndex vars)
        {
            Pattern = pattern;
            Variables = vars;
        }

        public string Id
        {
            [MethodImpl(Inline)]
            get => Pattern.PatternId;
        }

        public ref CmdVar this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Variables[index];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Pattern.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Pattern.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdScriptExpr(string src)
            => new CmdScriptExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator CmdScriptExpr(CmdPattern src)
            => api.expr(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdScriptExpr src)
            => src.Pattern;

        [MethodImpl(Inline)]
        public static implicit operator CmdScriptExpr(Paired<CmdPattern,CmdVarIndex> src)
            => api.expr(src);

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}