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
        public Type TargetType {get;}
     
        public bool Succeeded {get;}
        
        public object Value {get;}

        public Option<object> Reason {get;}

        [MethodImpl(Inline)]
        public static ParseResult<T> Success<T>(T value)
            => ParseResult<T>.Success(value);

        [MethodImpl(Inline)]
        public static ParseResult<T> Fail<T>(object reason = null)
            => ParseResult<T>.Fail(reason);

        [MethodImpl(Inline)]
        public static ParseResult Success(Type target, object value)
            => new ParseResult(target, true, value);

        [MethodImpl(Inline)]
        public static ParseResult Fail(Type target, object reason = null)
            => new ParseResult(target, false, null, reason);

        [MethodImpl(Inline)]
        public static ParseResult Define(Type target, bool succeeded,  object value, object reason = null)
            => new ParseResult(target, succeeded, value, reason);

        [MethodImpl(Inline)]
        ParseResult(Type type, bool succeeded, object value, object reason = null)
        {
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
        public bool Succeeded {get;}

        public T Value {get;}

        public Option<object> Reason {get;}

        [MethodImpl(Inline)]
        public static ParseResult<T> Success(T value)
            => new ParseResult<T>(value);

        [MethodImpl(Inline)]
        public static ParseResult<T> Fail(object reason = null)
            => new ParseResult<T>(default, reason);

        [MethodImpl(Inline)]
        public static implicit operator ParseResult(ParseResult<T> src)
            => ParseResult.Define(typeof(T), src.Succeeded, src.Value);
        
        [MethodImpl(Inline)]
        ParseResult(T value, object reason = null)
        {
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
            => Succeeded ? ParseResult<S>.Success(f(Value)) : ParseResult<S>.Fail();

        /// <summary>
        /// Implements the canonical bind operation
        /// </summary>
        /// <typeparam name="X">The source domain type</typeparam>
        /// <typeparam name="Y">The target domain type</typeparam>
        /// <param name="x">The point in the monadic space over X</param>
        /// <param name="f">The function to apply to effect the bind</param>
        public ParseResult<Y> Bind<Y>(Func<T, ParseResult<Y>> f)
            => Succeeded ? f(Value) : ParseResult<Y>.Fail();

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
            if (Succeeded)
            {
                var v = Value;
                var y = eval(v);
                var z = y.Bind(yVal => ParseResult<Z>.Success(project(v, yVal)));
                return z;
            }
            else
                return ParseResult<Z>.Fail();
        }


        public string Format()
            => ParseResult.Format(this);

        public override string ToString()
             => Format();
   }
}