//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static SpanKind;

    public readonly struct SpanTypeKind : ITypeKind<SpanTypeKind>
    {

    }        

    public readonly struct SpanTypeKind<T> : ITypeKind<SpanTypeKind<T>,T> 
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator SpanTypeKind(SpanTypeKind<T> src)
            =>  default;
    }        

    public enum SpanKind
    {
        None = 0,

        Mutable = 1,

        Immutable = 2
    }

    public static class SpanKindOps
    {
        [MethodImpl(Inline)]
        public static bool IsSome(this SpanKind kind)
            => kind != 0;

        [MethodImpl(Inline)]
        public static bool IsNone(this SpanKind kind)
            => kind == 0;

        public static string Format(this SpanKind kind)
            => kind.IsSome() ? (kind == Mutable ? IDI.Span : IDI.USpan) : string.Empty;
    }    
}