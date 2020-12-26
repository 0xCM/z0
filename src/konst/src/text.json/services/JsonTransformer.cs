//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct JsonTransformer<T> : IJsonTransformer<JsonTransformer<T>,T>
    {
        readonly ITextParser<T> Parser;

        readonly ITextFormatter<T> Formatter;

        internal JsonTransformer(ITextParser<T> parser, ITextFormatter<T> formatter)
        {
            Parser = parser;
            Formatter = formatter;
        }

        public string Project(T src)
            => Formatter.Format(src);

        public T Project(string src)
        {
            if(Parser.Parse(src, out var value))
                return value;
            else
                throw new Exception($"Json parse failed for intput {src} of type {typeof(T).Name}");
        }
    }
}