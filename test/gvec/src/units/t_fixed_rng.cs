//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static Konst;
    using static z;

    public class t_fixed_rng : t_inx<t_fixed_rng>
    {        
        T next<T>()
            where T : unmanaged
                => Random.Next<T>();

        public void fixed_emitter_8u()
        {
            const ulong tolerance = 5;
            var total = 0ul;
            var emit = FixedOps.fix(next<byte>); 
            for(var i=0; i<RepCount; i++ )
                total += Fixed.scalar(emit());

            var expect = (ulong)(maxval<byte>()/2);
            var actual = total/(ulong)RepCount;
            var succeeded = math.within(expect,actual,tolerance);

            if(!succeeded)
            {
                Trace($"expect := {expect}");
                Trace($"actual := {actual}");
            }

            Claim.Require(succeeded);            
        }
        
        public void fixed_convert()
        {
            BinaryOp<uint> f = gmath.add<uint>;
            BinaryOp32 g = FixedOps.fix(gmath.add<uint>);            
            var lhs = Random.FixedStream<Fixed32>().Take(RepCount).ToArray();
            var rhs = Random.FixedStream<Fixed32>().Take(RepCount).ToArray();

            void check()
            {
                var count = lhs.Length;
                for(var i=0; i<lhs.Length; i++)
                {
                    var a = lhs[i];
                    var b = rhs[i];
                    var x = Fixed.fix(f(a.Content, b.Content));
                    var y = g(a,b);
                    Claim.Eq(x,y);
                }
            }      
            
            CheckAction(check,nameof(fixed_convert));
        }
    }
}