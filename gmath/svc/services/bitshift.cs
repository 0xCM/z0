//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Core;

    partial class MathSvcHosts
    {
        [NumericClosures(NumericKind.Integers)]
        public readonly struct Srl<T> : ISImm8UnaryOpApi<T>, ISImm8SpanShiftApi<T>
            where T : unmanaged        
        {
            public const string Name = "srl";

            public static Srl<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, byte offset) 
                => gmath.srl(a, offset);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, byte count, Span<T> dst)
                => gspan.srl(src,count,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Sll<T> : ISImm8UnaryOpApi<T>, ISImm8SpanShiftApi<T>
            where T : unmanaged        
        {
            public const string Name = "sll";

            public static Sll<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, byte offset) 
                => gmath.sll(a, offset);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, byte count, Span<T> dst)
                => gspan.sll(src,count,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Sllv<T> : ISSpanShiftVarApi<T>
            where T : unmanaged        
        {
            public const string Name = "sllv";

            public static Sllv<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
                => gspan.sllv(src,counts,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Srlv<T> : ISSpanShiftVarApi<T>
            where T : unmanaged        
        {
            public const string Name = "srlv";

            public static Srlv<T> Op => default;

            public OpIdentity Id => Identify.SFunc<T>(Name);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
                => gspan.srlv(src,counts,dst);
        }
    }
}