//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [DataType]
    public readonly struct ParseResult2<S> : IParseResult2<S>
    {
        /// <summary>
        /// The content that was parsed...or not
        /// </summary>
        public S Source {get;}

        /// <summary>
        /// Specifies whether the parse attempt succeed, and thus the Value field is meaningful
        /// </summary>
        public bool Succeeded {get;}

        /// <summary>
        /// An optional message describing a parse failure
        /// </summary>
        public string Message {get;}

        [MethodImpl(Inline)]
        public ParseResult2(S source, bool succeeded, string message = EmptyString)
        {
            Source = source;
            Succeeded = succeeded;
            Message = message;
        }

        public bool Failed
        {
            [MethodImpl(Inline)]
            get => !Succeeded;
        }

        public string Format()
            => Succeeded
            ? string.Format("Parsed:{0}", Source)
            : string.Format("Unparsed:{0} - {1}", Source, Message);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static bool operator true(ParseResult2<S> src)
            => src.Succeeded;

        [MethodImpl(Inline)]
        public static bool operator false(ParseResult2<S> src)
            => src.Failed;

        [MethodImpl(Inline)]
        public static implicit operator bool(ParseResult2<S> src)
            => src.Succeeded;

        [MethodImpl(Inline)]
        public static implicit operator ParseResult2<S>(S src)
            => new ParseResult2<S>(src, true);

        [MethodImpl(Inline)]
        public static implicit operator ParseResult2<S>((S src, string msg) src)
            => new ParseResult2<S>(src.src, false, src.msg);

        [MethodImpl(Inline)]
        public static implicit operator ParseResult2<S>((S src, bool succeeded) src)
            => new ParseResult2<S>(src.src, src.succeeded);
    }
}