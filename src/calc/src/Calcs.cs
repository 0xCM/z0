//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    using K = ApiClassKind;

    [ApiHost]
    public readonly partial struct Calcs
    {
        const NumericKind Closure = Integers;


    }

    [ApiHost]
    public readonly struct CalcBuilder
    {
        const NumericKind Closure = Integers;

        [Op, Closures(UInt32k)]
        public static void calc<T>(ApiClassKind api, SpanBlock128<T> a, SpanBlock128<T> b, SpanBlock128<T> dst)
            where T : unmanaged
        {
            var w = w128;
            switch(api)
            {
                case K.Add:
                    Calcs.add<T>(w).Invoke(a, b, dst);
                break;
                case K.Sub:
                    Calcs.sub<T>(w).Invoke(a, b, dst);
                break;
                case K.Gt:
                    Calcs.gt<T>(w).Invoke(a, b, dst);
                break;
                case K.Lt:
                    Calcs.lt<T>(w).Invoke(a, b, dst);
                break;
                case K.And:
                    Calcs.and<T>(w).Invoke(a, b, dst);
                break;
                // case K.Or:
                //     Calcs.or<T>(w).Invoke(a, b, dst);
                // break;
                // case K.Xor:
                //     Calcs.xor<T>(w).Invoke(a, b, dst);
                // break;
                // case K.Xnor:
                //     Calcs.xnor<T>(w).Invoke(a, b, dst);
                // break;
                // case K.Nor:
                //     Calcs.nor<T>(w).Invoke(a, b, dst);
                // break;
                // case K.CImpl:
                //     Calcs.cimpl<T>(w).Invoke(a, b, dst);
                // break;
                // case K.CNonImpl:
                //     Calcs.cnonimpl<T>(w).Invoke(a, b, dst);
                // break;
                // case K.Impl:
                //     Calcs.impl<T>(w).Invoke(a, b, dst);
                // break;
                // case K.NonImpl:
                //     Calcs.nonimpl<T>(w).Invoke(a, b, dst);
                // break;
            }
        }

    }

    public static partial class XTend
    {

    }
}