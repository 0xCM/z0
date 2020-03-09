//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ParseResult : IParseResult, IFormattable<ParseResult>
    {
        /// <summary>
        /// The text that was parsed...or not
        /// </summary>
        public string Source {get;}
        
        /// <summary>
        /// The target value type
        /// </summary>
        public Type TargetType {get;}
     
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

        [MethodImpl(Inline)]
        public static ParseResult<T> Success<T>(string source, T value)
            => ParseResult<T>.Success(source, value);

        [MethodImpl(Inline)]
        public static ParseResult<T> Fail<T>(string source, object reason = null)
            => ParseResult<T>.Fail(source, reason);

        [MethodImpl(Inline)]
        public static ParseResult Success(string source, Type target, object value)
            => new ParseResult(source, target, true, value);

        [MethodImpl(Inline)]
        public static ParseResult Fail(string source, Type target, object reason = null)
            => new ParseResult(source, target, false, null, reason);

        [MethodImpl(Inline)]
        public static ParseResult Define(string source, Type target, bool succeeded,  object value, object reason = null)
            => new ParseResult(source, target, succeeded, value, reason);

        [MethodImpl(Inline)]
        ParseResult(string source, Type type, bool succeeded, object value, object reason = null)
        {
            Source = source;
            TargetType = type;
            Succeeded = succeeded;
            Value = value;
            Reason = reason != null ? some(reason) : none<object>();
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

    public readonly struct ParseResult<T> : IParseResult<T>, IFormattable<ParseResult<T>>
    {
        /// <summary>
        /// The text that was parsed...or not
        /// </summary>
        public string Source {get;}

        /// <summary>
        /// Specifies whether the parse attempt succeed, and thus the Value field is meaningful
        /// </summary>
        public bool Succeeded {get;}

        /// <summary>
        /// Upon successful parse attempt, holds the parsed value; otherwise it may or may not hold something else
        /// </summary>
        public T Value {get;}

        public Option<object> Reason {get;}

        [MethodImpl(Inline)]
        public static ParseResult<T> Success(string source, T value)
            => new ParseResult<T>(source, value);

        [MethodImpl(Inline)]
        public static ParseResult<T> Fail(string source, object reason = null)
            => new ParseResult<T>(source, default, reason);

        [MethodImpl(Inline)]
        public static implicit operator ParseResult(ParseResult<T> src)
            => ParseResult.Define(src.Source, typeof(T), src.Succeeded, src.Value);
        
        [MethodImpl(Inline)]
        ParseResult(string source, T value, object reason = null)
        {
            this.Source = source;
            this.Succeeded = true;
            this.Value = value;
            this.Reason = reason != null ? some(reason) : none<object>();
        }        

        /// <summary>
        /// Invokes an action if the value exists
        /// </summary>
        /// <param name="ifSome">The action to potentially ivoke</param>
        [MethodImpl(Inline)]
        public ParseResult<T> OnSuccess(Action<T> ifSome)
        {
            if (Succeeded)
                ifSome(Value);
            return this;
        }

        /// <summary>
        /// Invokes an action if the value doesn't exist
        /// </summary>
        /// <param name="f">The action to invoke</param>
        [MethodImpl(Inline)]
        public ParseResult<T> OnFailure(Action f)
        {
            if (!Succeeded)
                f();
            return this;
        }

        /// <summary>
        /// Maps the parsed value upon success and the source text upon failure
        /// </summary>
        /// <param name="success">The success projector</param>
        /// <param name="failure">The failure projector</param>
        /// <typeparam name="Y">The target type</typeparam>
        [MethodImpl(Inline)]
        public Y MapValueOrSource<Y>(Func<T,Y> success, Func<string,Y> failure)
            =>  Succeeded ? success(Value) : failure(Source);

        /// <summary>
        /// Extracts the encapulated value if it exists; otherwise, returns the default value for
        /// the underlying type which is NULL for reference types
        /// </summary>
        /// <param name="default">The value to return if the option is non-valued</param>
        [MethodImpl(Inline)]
        public T ValueOrDefault(T @default = default(T))
            => Succeeded ? Value : @default;

        /// <summary>
        /// Returns the encapsulated value if it exists; otherwise, invokes the supplied fallback function 
        /// </summary>
        /// <param name="fallback">The function called to produce a value when there is no value in the source</param>
        [MethodImpl(Inline)]
        public T ValueOrElse(Func<T> fallback)
            => Succeeded ? Value : fallback();

        /// <summary>
        /// Applies a function to value if present, otherwise returns None
        /// </summary>
        /// <typeparam name="S">The output type</typeparam>
        /// <param name="f">The function to apply when value exists</param>
        [MethodImpl(Inline)]
        public ParseResult<S> TryMap<S>(Func<T, S> f)
            => Succeeded ? ParseResult<S>.Success(Source, f(Value)) : ParseResult<S>.Fail(Source);

        /// <summary>
        /// Implements the canonical bind operation
        /// </summary>
        /// <typeparam name="X">The source domain type</typeparam>
        /// <typeparam name="Y">The target domain type</typeparam>
        /// <param name="x">The point in the monadic space over X</param>
        /// <param name="f">The function to apply to effect the bind</param>
        public ParseResult<Y> Bind<Y>(Func<T, ParseResult<Y>> f)
            => Succeeded ? f(Value) : ParseResult<Y>.Fail(Source);

        /// <summary>
        /// LINQ integration function
        /// </summary>
        /// <param name="apply">The application projector</param>
        /// <typeparam name="Y">The application range</typeparam>
        [MethodImpl(Inline)]
        public ParseResult<Y> Select<Y>(Func<T, Y> apply)
            => TryMap(_x => apply(_x));

        /// <summary>
        /// LINQ integration function
        /// </summary>
        /// <param name="eval">The evaluator</param>
        /// <param name="project">The lifting projector</param>
        /// <typeparam name="Y">The evaluator range type</typeparam>
        /// <typeparam name="Z">The projector range type</typeparam>
        [MethodImpl(Inline)]
        public ParseResult<Z> SelectMany<Y, Z>(Func<T, ParseResult<Y>> eval, Func<T, Y, Z> project)
        {
            var src = Source;
            if (Succeeded)
            {
                var v = Value;
                var y = eval(v);
                var z = y.Bind(yVal => ParseResult<Z>.Success(src, project(v, yVal)));
                return z;
            }
            else
                return ParseResult<Z>.Fail(src);
        }

        public string Format()
            => ParseResult.Format(this);

        public override string ToString()
             => Format();
   }
}