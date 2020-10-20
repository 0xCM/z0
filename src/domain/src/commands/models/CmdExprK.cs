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

    public readonly struct CmdExpr<K> : ITextual, IIdentified<string>
        where K : unmanaged
    {
        public CmdPattern Pattern {get;}

        public CmdVars<K> Variables {get;}

        [MethodImpl(Inline)]
        internal CmdExpr(CmdPattern pattern)
        {
            Pattern = pattern;
            Variables = api.vars<K>();
        }

        [MethodImpl(Inline)]
        public CmdExpr(CmdPattern pattern, CmdVars<K> vars)
        {
            Pattern = pattern;
            Variables = vars;
        }

        public string Id
        {
            [MethodImpl(Inline)]
            get => Pattern.Id;
        }

        public ref CmdVar<K> this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Variables[index];
        }

        [MethodImpl(Inline)]
        public static implicit operator string(CmdExpr<K> src)
            => src.Format();

       [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
     }
}