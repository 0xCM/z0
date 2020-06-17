//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]    
        public static T Map<S,T>(this S src, Func<S,T> f, T @default = default)
            where S : INullaryKnown
            where T : new()
                => src.IsNonEmpty ? f(src) : @default ?? new T();        
        
        [MethodImpl(Inline)]    
        public static T Map<S,T>(this S src, Func<S,T> f)
            where S : INullaryKnown
            where T : INullary<T>, new()
                => src.IsNonEmpty ? f(src) : new T().Zero;
    }
}