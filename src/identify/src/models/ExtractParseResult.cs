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
    using static Memories;

    public readonly struct ExtractParseResult
    {
        [MethodImpl(Inline)]
        public static ExtractParseResult FromFailure(ExtractParseFailure fail)
            => new ExtractParseResult(fail);

        [MethodImpl(Inline)]
        public static ExtractParseResult FromSuccess(ParsedMember parsed)
            => new ExtractParseResult(parsed);
        
        readonly Either<ExtractParseFailure,ParsedMember> Outcome;

        [MethodImpl(Inline)]
        public static implicit operator ExtractParseResult(ExtractParseFailure src)
            => new ExtractParseResult(src);

        [MethodImpl(Inline)]
        public static implicit operator ExtractParseResult(ParsedMember src)
            => new ExtractParseResult(src);

        [MethodImpl(Inline)]
        public ExtractParseResult(ExtractParseFailure src)
            => Outcome = src;

        [MethodImpl(Inline)]
        public ExtractParseResult(ParsedMember src)
            => Outcome = src;

        public bool Failed 
            => Outcome.IsLeft;

        public bool Succeeded 
            => Outcome.IsRight;

        public Option<ParsedMember> ParsedMember 
            => Outcome.IsRight ? Outcome.Right : none<ParsedMember>();
        
        public Option<ExtractParseFailure> FailureInfo
            => Outcome.IsLeft ? Outcome.Left : none<ExtractParseFailure>();  

        [MethodImpl(Inline)]
        public void OnSuccess(Action<ParsedMember> f)         
            => Outcome.OnRight(f);      

        [MethodImpl(Inline)]
        public void OnFailure(Action<ExtractParseFailure> f) 
            => Outcome.OnLeft(f);     

        [MethodImpl(Inline)]
        public void OnResult(Action<ExtractParseFailure> failed, Action<ParsedMember> success) 
            => Outcome.OnEither(failed, success);

        [MethodImpl(Inline)]
        public T Map<T>(Func<ExtractParseFailure,T> failed, Func<ParsedMember,T> success) 
            => Outcome.Map(failed,success);
    }
}