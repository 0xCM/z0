//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdScriptExpr<K> : ICmdScriptExpr
        where K : unmanaged
    {
        public CmdPattern Pattern {get;}

        public CmdVarIndex<K> Variables {get;}

        [MethodImpl(Inline)]
        internal CmdScriptExpr(CmdPattern pattern)
        {
            Pattern = pattern;
            Variables = CmdVars.init<K>();
        }

        [MethodImpl(Inline)]
        public CmdScriptExpr(CmdPattern pattern, CmdVarIndex<K> vars)
        {
            Pattern = pattern;
            Variables = vars;
        }

        public string Id
        {
            [MethodImpl(Inline)]
            get => Pattern.PatternId;
        }

        public ref CmdVar<K> this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Variables[index];
        }

        [MethodImpl(Inline)]
        public static implicit operator string(CmdScriptExpr<K> src)
            => src.Format();

       [MethodImpl(Inline)]
        public string Format()
            => CmdScripts.format(this);

        public override string ToString()
            => Format();
     }
}