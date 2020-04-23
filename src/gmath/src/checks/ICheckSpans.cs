//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct CheckSpans : ICheckSpans
    {
        public static ICheckSpans Checker => default(CheckSpans);
        
    }

    public interface ICheckSpans : IValidator, ICheckGeneric
    {
        void eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => Spans.iter(lhs, rhs, (a,b) => numeq(a,b, caller,file,line));

        void eq<T>(Span<T> lhs, Span<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged             
                => Spans.iter(lhs,rhs, (a,b) => numeq(a,b, caller,file,line));        
    }
}