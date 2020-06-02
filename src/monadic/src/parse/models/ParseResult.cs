//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Monadic;

    public readonly struct ParseResult : IParseResult
    {
        /// <summary>
        /// The content that was parsed...or not
        /// </summary>
        public object Source {get;}
        
        /// <summary>
        /// The target value type
        /// </summary>
        public Type TargetType {get;}
     
        /// <summary>
        /// The source type
        /// </summary>
        public Type SourceType {get;}
        
        /// <summary>
        /// Specifies whether the parse attempt succeed, and thus the Value field is meaningful
        /// </summary>
        public bool Succeeded {get;}

        /// <summary>
        /// The parsed value, if the parse operaion succeedeed; otherwise best not look there
        /// </summary>
        public object Value {get;}

        /// <summary>
        /// If the parse attempt failed, the reason for the failure, if available
        /// </summary>
        public Option<object> Reason {get;}

        public bool Failed  
        {
            [MethodImpl(Inline)]
            get => !Succeeded;
        }

        /// <summary>
        /// Defines a successful parse result
        /// </summary>
        /// <param name="source">The input text</param>
        /// <param name="value">The parsed value</param>
        /// <typeparam name="T">The parsed value type</typeparam>
        [MethodImpl(Inline)]
        public static ParseResult<T> Success<T>(string source, T value)
            => ParseResult<T>.Success(source, value);

        [MethodImpl(Inline)]
        public static ParseResult<T> Success<T>(char source, T value)
            => ParseResult<T>.Success(source.ToString(), value);

        [MethodImpl(Inline)]
        public static ParseResult<T> Fail<T>(string source, object reason = null)
            => ParseResult<T>.Fail(source, reason);

        [MethodImpl(Inline)]
        public static ParseResult<T> Fail<T>(char source, object reason = null)
            => ParseResult<T>.Fail(source.ToString(), reason);

        /// <summary>
        /// Defines a successful parse result
        /// </summary>
        /// <param name="source">The input vaue</param>
        /// <param name="value">The parsed value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ParseResult<S,T> Success<S,T>(S source, T value)
            => ParseResult<S,T>.Success(source, value);

        /// <summary>
        /// Defines a parse result that signals failure
        /// </summary>
        /// <param name="source">The input vaue</param>
        /// <param name="reason">The failure reason, if available</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ParseResult<S,T> Fail<S,T>(S source, object reason = null)
            => ParseResult<S,T>.Fail(source, reason);

        [MethodImpl(Inline)]
        public static ParseResult Success(string source, Type target, object value)
            => new ParseResult(source, target, true, value);

        [MethodImpl(Inline)]
        public static ParseResult Fail(string source, Type target, object reason = null)
            => new ParseResult(source, target, false, null, reason);

        [MethodImpl(Inline)]
        public static ParseResult Define(string source, Type target, bool succeeded, object value, object reason = null)
            => new ParseResult(source, target, succeeded, value, reason);

        [MethodImpl(Inline)]
        public static ParseResult Success(object src, Type srcType, Type dstType, object dst, object reason = null)
            => new ParseResult(src, srcType, dstType, true, dst, reason);

        [MethodImpl(Inline)]
        public static ParseResult Fail(object src, Type srcType, Type dstType, object reason = null)
            => new ParseResult(src, srcType, dstType, false, DBNull.Value, reason);

        [MethodImpl(Inline)]
        public static bool operator true(ParseResult src)
            => src.Succeeded;

        [MethodImpl(Inline)]
        public static bool operator false(ParseResult src)
            => src.Failed;

        [MethodImpl(Inline)]
        internal ParseResult(object source, Type sourceType, Type targetType, bool succeeded, object value, object reason = null)
        {
            Source = source;
            SourceType = sourceType;
            TargetType = targetType;
            Succeeded = succeeded;
            Value = value;
            Reason = reason != null ? Option.some(reason) : Option.none<object>();
        }

        [MethodImpl(Inline)]
        internal ParseResult(object source, Type targetType, bool succeeded, object value, object reason = null)
        {
            Source = source;
            SourceType = source?.GetType() ?? typeof(void);
            TargetType = targetType;
            Succeeded = succeeded;
            Value = value;
            Reason = reason != null ? Option.some(reason) : Option.none<object>();
        }

        public static string Format(ParseResult src)
        {
            if(src.Succeeded)
                return src.Value?.ToString() ?? "Parse result indicates sucess but no value present!";
            else
                return src.Reason.MapValueOrDefault(reason => reason.ToString(), "Reason for parse failure unspecified");
        }

        public string Format()
            => Format(this);

        public override string ToString()
             => Format();
    }
}