//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ScriptExpr : ICmdScriptExpr
    {
        [MethodImpl(Inline), Op]
        public static ScriptExpr define(ScriptPattern pattern)
            => new ScriptExpr(pattern);

        [MethodImpl(Inline), Op]
        public static ScriptExpr define(ScriptPattern pattern, Index<CmdVar> vars)
            => new ScriptExpr(pattern, vars);

        [MethodImpl(Inline)]
        public static ScriptExpr<K> define<K>(ScriptPattern pattern, Index<CmdVar<K>> vars)
            where K : unmanaged
                => new ScriptExpr<K>(pattern, vars);

        [MethodImpl(Inline)]
        public static ScriptExpr<K,T> define<K,T>(K id, T content)
            where K : unmanaged
                => new ScriptExpr<K,T>(id,content);
        public ScriptPattern Pattern {get;}

        public Index<CmdVar> Variables {get;}

        [MethodImpl(Inline)]
        public ScriptExpr(string pattern)
        {
            Pattern = pattern;
            Variables = Cmd.vars();
        }

        [MethodImpl(Inline)]
        public ScriptExpr(ScriptPattern pattern)
        {
            Pattern = pattern;
            Variables = Cmd.vars();
        }

        [MethodImpl(Inline)]
        public ScriptExpr(ScriptPattern pattern, Index<CmdVar> vars)
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
        public static implicit operator ScriptExpr(string src)
            => new ScriptExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator ScriptExpr(ScriptPattern src)
            => define(src);

        [MethodImpl(Inline)]
        public static implicit operator string(ScriptExpr src)
            => src.Pattern;


        [MethodImpl(Inline)]
        public string Format()
            => CmdRender.format(this);

        public override string ToString()
            => Format();
    }
}