//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public readonly struct ParseResult : IParseResult
    {
        public Type TargetType {get;}
     
        public bool Succeeded {get;}
        
        public object Value {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public static ParseResult<T> Success<T>(T value, string info = null)
            => ParseResult<T>.Success(value);

        [MethodImpl(Inline)]
        public static ParseResult<T> Fail<T>(string info = null)
            => ParseResult<T>.Fail(info);

        [MethodImpl(Inline)]
        public static ParseResult Success(Type target, object value, string info = null)
            => new ParseResult(target, true, value, info);

        [MethodImpl(Inline)]
        public static ParseResult Fail(Type target, string info = null)
            => new ParseResult(target, false, null, info);

        [MethodImpl(Inline)]
        public static ParseResult Define(Type target, bool succeeded,  object value, string info = null)
            => new ParseResult(target, succeeded, value, info);

        [MethodImpl(Inline)]
        ParseResult(Type type, bool succeeded, object value, string info = null)
        {
            TargetType = type;
            Succeeded = succeeded;
            Value = value;
            Description = info ?? string.Empty;
        }

        public override string ToString()
            => Succeeded ? (Value?.ToString() ?? "novalue") : Description;
    }

    public readonly struct ParseResult<T> : IParseResult<T>
    {
        public bool Succeeded {get;}

        public T Value {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public static ParseResult<T> Success(T value, string info = null)
            => new ParseResult<T>(value, info);

        [MethodImpl(Inline)]
        public static ParseResult<T> Fail(string info = null)
            => new ParseResult<T>(default, info);

        [MethodImpl(Inline)]
        public static implicit operator ParseResult(ParseResult<T> src)
            => ParseResult.Define(typeof(T), src.Succeeded, src.Value);
        
        [MethodImpl(Inline)]
        ParseResult(T value, string info = null)
        {
            this.Succeeded = true;
            this.Value = value;
            this.Description = info ?? string.Empty;
        }        


        public override string ToString()
            => Succeeded ? (Value?.ToString() ?? "novalue") : Description;
    }
}