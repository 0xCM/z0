//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public class t_uint3 : t_uint<t_uint3>
    {
        public static ComparisonResult<ComparisonKind,T,R> eq<T,R>(T lhs, T rhs, R outcome)
        {
            var dst = new ComparisonResult<ComparisonKind,T,R>();
            dst.Operator = ComparisonKind.Eq;
            dst.Left = lhs;
            dst.Right = rhs;
            dst.Outcome = outcome;
            return dst;
        }

        public void t_uint3_reduce()
        {
            var source = Random.Span<byte>(PointCount);
            var actual = span<uint3>(PointCount);
            var expect = span<uint3>(PointCount);
            var result = span<ComparisonResult<ComparisonKind,uint3,bool>>(PointCount);

            for(var i=0; i<PointCount; i++)
                seek(expect,i) = BitNumbers.inject(math.mod(skip(source,i), uint3.Mod), w3);

            for(var i=0; i<PointCount; i++)
                seek(actual,i) = BitNumbers.uint3(skip(source,i));

            for(var i=0; i<PointCount; i++)
            {
                ref readonly var a = ref skip(expect,i);
                ref readonly var b = ref skip(actual,i);
                seek(result,i) = eq(a,b, a == b);
            }

            Analyze(result);
        }

        void Analyze(ReadOnlySpan<ComparisonResult<ComparisonKind,uint3,bool>> src )
        {
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var a = ref skip(src,i);
                if(!a.Outcome)
                {
                    Trace($"{a.Left} != {a.Right}");
                }
            }
        }
    }
}
