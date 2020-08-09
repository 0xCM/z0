//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static Konst;

    public readonly struct ExtractParseResult
    {
        readonly Either<ExtractParseFailure,ParsedExtraction> Outcome;

        [MethodImpl(Inline)]
        public static ExtractParseResult FromFailure(ExtractParseFailure fail)
            => new ExtractParseResult(fail);

        [MethodImpl(Inline)]
        public static ExtractParseResult FromSuccess(ParsedExtraction parsed)
            => new ExtractParseResult(parsed);        

        [MethodImpl(Inline)]
        public static implicit operator ExtractParseResult(ExtractParseFailure src)
            => new ExtractParseResult(src);

        [MethodImpl(Inline)]
        public static implicit operator ExtractParseResult(ParsedExtraction src)
            => new ExtractParseResult(src);

        [MethodImpl(Inline)]
        public ExtractParseResult(ExtractParseFailure src)
            => Outcome = src;

        [MethodImpl(Inline)]
        public ExtractParseResult(ParsedExtraction src)
            => Outcome = src;

        public bool Failed 
            => Outcome.IsLeft;

        public bool Succeeded 
            => Outcome.IsRight;

        public Option<ParsedExtraction> ParsedMember 
            => Outcome.IsRight ? Outcome.Right : Option.none<ParsedExtraction>();
        
        public Option<ExtractParseFailure> FailureInfo
            => Outcome.IsLeft ? Outcome.Left : Option.none<ExtractParseFailure>();  

        [MethodImpl(Inline)]
        public void OnSuccess(Action<ParsedExtraction> f)         
            => Outcome.OnRight(f);      

        [MethodImpl(Inline)]
        public void OnFailure(Action<ExtractParseFailure> f) 
            => Outcome.OnLeft(f);     

        [MethodImpl(Inline)]
        public void OnResult(Action<ExtractParseFailure> failed, Action<ParsedExtraction> success) 
            => Outcome.OnEither(failed, success);

        [MethodImpl(Inline)]
        public T Map<T>(Func<ExtractParseFailure,T> failed, Func<ParsedExtraction,T> success) 
            => Outcome.Map(failed,success);
    }
}