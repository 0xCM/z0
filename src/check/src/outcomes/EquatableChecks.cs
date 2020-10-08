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
    using api = Judgements;

    public readonly struct EquatableChecks
    {
        [MethodImpl(Inline)]
        public static ref SequenceJudgement<T> check<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ref SequenceJudgement<T> dst)
            where T : IEquatable<T>
        {
            var count = a.Length;
            if(count != b.Length || count == 0)
                return ref dst;

            var success = bit.On;
            for(var i=0u; i<count; i++)
            {
                ref readonly var x = ref skip(a,i);
                ref readonly var y = ref skip(b,i);
                dst[i] = check(x,y, out var judgement);
                success &= judgement.Success;
            }
            dst.Result = success;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref BinaryJudgement<T> check<T>(T a, T b, out BinaryJudgement<T> dst)
            where T : IEquatable<T>
        {
            dst = api.binary(a,b,a.Equals(b));
            return ref dst;
        }
    }
}