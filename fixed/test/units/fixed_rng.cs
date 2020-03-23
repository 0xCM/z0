//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static Nats;
    using R = OperationClassReps;

    public class t_fixed_rng : UnitTest<t_fixed_rng>
    {        

        T next<T>()
            where T : unmanaged
                => Random.Next<T>();


        public void fixed_emitter_8u()
        {
            const ulong tolerance = 5;
            var total = 0ul;
            var emit = Fixed.fix(next<byte>); 
            for(var i=0; i<RepCount; i++ )
                total += Fixed.unfix(emit());

            var expect = (ulong)(maxval<byte>()/2);
            var actual = total/(ulong)RepCount;
            var succeeded = math.within(expect,actual,tolerance);

            if(!succeeded)
            {
                print($"expect := {expect}");
                print($"actual := {actual}");
            }

            Claim.yea(succeeded);            
        }

        public void fixed_convert()
        {
            BinaryOp<uint> f = gmath.add<uint>;
            BinaryOp32 g = Fixed.fix(gmath.add<uint>);            
            var lhs = Random.FixedStream<Fixed32>().Take(RepCount).ToArray();
            var rhs = Random.FixedStream<Fixed32>().Take(RepCount).ToArray();

            void check()
            {
                var count = lhs.Length;
                for(var i=0; i<lhs.Length; i++)
                {
                    var a = lhs[i];
                    var b = rhs[i];
                    var x = Fixed.fix(f(a.Data, b.Data));
                    var y = g(a,b);
                    Claim.eq(x,y);
                }
            }      
            CheckAction(check,nameof(fixed_convert));

        }
    }
}
        
