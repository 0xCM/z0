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
        [MethodImpl(Inline)]
        public static ParseResult<T> Success<T>(T value)
            => ParseResult<T>.Success(value);

        [MethodImpl(Inline)]
        public static ParseResult Success(Type target, object value)
            => new ParseResult(target,value);

        [MethodImpl(Inline)]
        public static ParseResult Fail(Type target)
            => new ParseResult(target,null);

        [MethodImpl(Inline)]
        ParseResult(Type type, object value)
        {
            TargetType = type;
            Succeeded = value != null;
            Value = value;
        }

        public Type TargetType {get;}
     
        public bool Succeeded {get;}
        
        public object Value {get;}

        public override string ToString()
            => Succeeded ? (Value?.ToString() ?? string.Empty) : string.Empty;
    }

    public readonly struct ParseResult<T> : IParseResult<T>
    {
        [MethodImpl(Inline)]
        public static ParseResult<T> Success(T value)
            => new ParseResult<T>(value);

        [MethodImpl(Inline)]
        public static ParseResult<T> Fail()
            => default;

        [MethodImpl(Inline)]
        ParseResult(T value)
        {
            this.Succeeded = true;
            this.Value = value;
        }        

        public bool Succeeded {get;}

        public T Value {get;}

        public override string ToString()
            => Succeeded ? (Value?.ToString() ?? string.Empty) : string.Empty;
    }
}