//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    partial class GXTypes
    {
        [NumericClosures(NumericKind.Integers)]
        public readonly struct Srl<T> : IShiftOp<T>, IShiftSpanOp<T>
            where T : unmanaged        
        {
            public const string Name = "srl";

            public static Srl<T> Op => default;

            public OpIdentity Id => Identity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, byte offset) 
                => gmath.srl(a, offset);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, byte count, Span<T> dst)
                => mathspan.srl(src,count,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Sll<T> : IShiftOp<T>, IShiftSpanOp<T>
            where T : unmanaged        
        {
            public const string Name = "sll";

            public static Sll<T> Op => default;

            public OpIdentity Id => Identity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, byte offset) 
                => gmath.sll(a, offset);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, byte count, Span<T> dst)
                => mathspan.sll(src,count,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Sllv<T> : IVarShiftSpanOp<T>
            where T : unmanaged        
        {
            public const string Name = "sllv";

            public static Sllv<T> Op => default;

            public OpIdentity Id => Identity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
                => mathspan.sllv(src,counts,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Srlv<T> : IVarShiftSpanOp<T>
            where T : unmanaged        
        {
            public const string Name = "srlv";

            public static Srlv<T> Op => default;

            public OpIdentity Id => Identity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
                => mathspan.srlv(src,counts,dst);
        }
    }
}