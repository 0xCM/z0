//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct EvalResults
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static BinaryEval<K,T,R> binary<K,T,R>(K kind, T a, T b, R result)
        {
            var dst = new BinaryEval<K,T,R>();
            dst.Kind = kind;
            dst.A = a;
            dst.B = b;
            dst.Result = result;
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmpEval<T> eq<T>(T a, T b, bit equal)
        {
            var dst = new CmpEval<T>();
            dst.Kind = ComparisonKind.Eq;
            dst.A = a;
            dst.B = b;
            dst.Result = equal;
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmpEval<T> gt<T>(T a, T b, bit result)
        {
            var dst = new CmpEval<T>();
            dst.Kind = ComparisonKind.Gt;
            dst.A = a;
            dst.B = b;
            dst.Result = result;
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmpEval<T> gteq<T>(T a, T b, bit result)
        {
            var dst = new CmpEval<T>();
            dst.Kind = ComparisonKind.GtEq;
            dst.A = a;
            dst.B = b;
            dst.Result = result;
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmpEval<T> lt<T>(T a, T b, bit result)
        {
            var dst = new CmpEval<T>();
            dst.Kind = ComparisonKind.Lt;
            dst.A = a;
            dst.B = b;
            dst.Result = result;
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmpEval<T> lteq<T>(T a, T b, bit result)
        {
            var dst = new CmpEval<T>();
            dst.Kind = ComparisonKind.LtEq;
            dst.A = a;
            dst.B = b;
            dst.Result = result;
            return dst;
        }

    }
}