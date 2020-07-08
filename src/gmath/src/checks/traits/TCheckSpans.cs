//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface TCheckSpans : TValidator, TCheckGeneric
    {
        void Eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => core.iter(lhs, rhs, (a,b) => NumEq(a,b, caller,file,line));

        void Eq<T>(Span<T> lhs, Span<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged             
                => core.iter(lhs,rhs, (a,b) => NumEq(a,b, caller,file,line));        
    }
}