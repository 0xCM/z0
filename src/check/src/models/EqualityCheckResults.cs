//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using R = EqualityCheckResults;



    public readonly struct EquatableChecks
    {
        public static Outcome check<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, R.SpanItems<T> dst)
            where T : IEquatable<T>
        {

            ref readonly var lhs = ref first(a);
            ref readonly var rhs = ref first(b);

            return default;
        }


    }

    public readonly struct EqualityCheckResults
    {

        public readonly struct ItemEquality<T>
        {
            public readonly T A;

            public readonly T B;

            public readonly bit Equal;

            public ItemEquality(T a, T b, bit result)
            {
                A = a;
                B = b;
                Equal = result;
            }
        }

        public readonly ref struct SpanItems<T>
        {
            public readonly Span<T> A;

            public readonly Span<T> B;

            public readonly Span<ItemEquality<T>> Equal;

            public SpanItems(Span<T> a, Span<T> b, Span<ItemEquality<T>> result)
            {
                A = a;
                B = b;
                Equal = result;
            }
        }
    }
}