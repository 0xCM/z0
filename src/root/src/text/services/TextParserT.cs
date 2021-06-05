//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TextParser<T> : ITextParser<T>
    {
        readonly ParserDelegate<T> Fx;

        [MethodImpl(Inline)]
        public TextParser(ParserDelegate<T> f)
        {
            Fx= f;
        }

        [MethodImpl(Inline)]
        public TextParser(ParseFunction<T> f)
        {
            Fx= f;
        }

        [MethodImpl(Inline)]
        public Outcome Parse(in string src, out T dst)
            => Fx.Invoke(src, out dst);


        [MethodImpl(Inline)]
        public Outcome<T> Parse(in string src)
        {
            var outcome = Parse(src, out T dst);
            return outcome ? dst : outcome;
        }

        [MethodImpl(Inline)]
        public bool Parse(in string src, out T dst, out Outcome result)
        {
            result = Parse(src, out dst);
            return result;
        }

        [MethodImpl(Inline)]
        public static implicit operator TextParser<T>(ParserDelegate<T> src)
            => new TextParser<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator TextParser(TextParser<T> src)
            => new TextParser(src);
    }
}