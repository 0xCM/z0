//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; 

    using K = Kinds;

    partial class MathSvcTypes
    {
        [Closures(Integers)]
        public readonly struct Sll<T> : IShiftOpSvc<K.Sll<T>,T>
            where T : unmanaged        
        {
            public const string Name = "sll";

            public static Sll<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, byte offset) 
                => gmath.sll(a, offset);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, byte count, Span<T> dst)
                => gspan.sll(src,count,dst);
        }

        [Closures(Integers)]
        public readonly struct Sllv<T> : IVarShiftOpSvc<K.Sllv<T>,T>
            where T : unmanaged        
        {
            public const string Name = "sllv";

            public static Sllv<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
                => gspan.sllv(src,counts,dst);
        }

    }
}