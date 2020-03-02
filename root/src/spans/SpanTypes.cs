//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct SpanType : ITypeKind<SpanType>
    {

    }        

    public readonly struct SpanType<T> : ITypeKind<SpanType<T>,T> 
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator SpanType(SpanType<T> src)
            =>  default;
    }        
}