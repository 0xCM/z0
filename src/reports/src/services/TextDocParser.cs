//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct TextDocParser
    {
        /// <summary>
        /// Creates a text document parser from a parse function
        /// </summary>
        /// <param name="f">The parse function</param>
        /// <typeparam name="T">The parsed type</typeparam>
        public static ITextDocParser<T> Create<T>(Func<TextDoc,ParseResult<T>> f)
            => new TextDocParser<T>(f);
    }
    
    public interface ITextDocParser<T> : ITextParser<T>
    {
        ParseResult<T> Parse(TextDoc src);    

        ParseResult<T> ITextParser<T>.Parse(string src)
        {
            using var stream = text.stream(src);
            using var reader = new StreamReader(stream);
            return reader.ParseDocument().TryMap(Parse).ValueOrDefault(ParseResult.Fail<T>(src));            
        }
    }
    
    public readonly struct TextDocParser<T> : ITextDocParser<T>
    {
        readonly Func<TextDoc,ParseResult<T>> f;

        [MethodImpl(Inline)]
        public TextDocParser(Func<TextDoc,ParseResult<T>> f)
        {
            this.f = f;
        }

        public ParseResult<T> Parse(TextDoc src)
            => f(src);        
    }
}