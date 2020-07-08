//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline)]        
        public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src)                
            where S : struct
            where T : struct
                => recover<S,T>(src);

        [MethodImpl(Inline)]        
        public static Span<T> cast<S,T>(Span<S> src)                
            where S : struct
            where T : struct
                => recover<S,T>(src); 
    }
}