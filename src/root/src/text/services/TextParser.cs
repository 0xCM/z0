//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TextParser : ITextParser
    {

        [MethodImpl(Inline)]
        public static TextParser create(ITextParser inner)
            => new TextParser(inner);


        [MethodImpl(Inline)]
        public static TextParser<T> create<T>(ParserDelegate<T> f)
            => f;

        [MethodImpl(Inline)]
        public static TextParser<T> create<T>(ParseFunction<T> f)
            => f;

        readonly ParserDelegate Fx;

        public Type TargetType {get;}

        [MethodImpl(Inline)]
        public TextParser(ITextParser inner)
        {
            TargetType = inner.TargetType;
            Fx = inner.ToDelegate();
        }
        public Type SourceType
        {
            [MethodImpl(Inline)]
            get => typeof(string);
        }

        [MethodImpl(Inline)]
        public Outcome Parse(string src, out dynamic dst)
            => Fx.Invoke(src, out dst);
    }
}