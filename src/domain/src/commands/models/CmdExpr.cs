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

    public readonly struct CmdExpr : ITextual, IIdentified<string>
    {
        public CmdPattern Pattern {get;}

        public CmdVars Variables {get;}

        [MethodImpl(Inline)]
        public CmdExpr(string pattern)
        {
            Pattern = pattern;
            Variables = api.vars();
        }

        [MethodImpl(Inline)]
        internal CmdExpr(CmdPattern pattern)
        {
            Pattern = pattern;
            Variables = api.vars();
        }

        [MethodImpl(Inline)]
        internal CmdExpr(CmdPattern pattern, CmdVars vars)
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
        public static implicit operator CmdExpr(string src)
            => new CmdExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator CmdExpr(CmdPattern src)
            => api.expr(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdExpr src)
            => src.Pattern;

        [MethodImpl(Inline)]
        public static implicit operator CmdExpr(Paired<CmdPattern,CmdVars> src)
            => api.expr(src);

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}