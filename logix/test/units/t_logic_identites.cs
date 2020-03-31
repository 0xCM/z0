
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    
    using static root;
    using static Nats;

    using static BitLogicSpec;

    public class t_logic_identities : UnitTest<t_logic_identities>
    {
        protected override int CycleCount 
            => Pow2.T14;

        public void check_identities()
        {
            iter(LogicIdentities.All, check_exhaustive);
        }
        
        void check_exhaustive(ComparisonExpr t)
        {
            
            foreach(var c in bitcombo(t.Vars.Length))
            {
                t.SetVars(c);
                Claim.eq(bit.On,LogicEngine.eval(t));            
                Claim.require(LogicEngine.satisfied(t, c[0], c[1]));
                
            }
        }

        public void identity_bench()
        {
            if(parity.odd(time.now().Ticks))
            {
                evaluator_bench();
            }
            else
            {
                evaluator_bench();

            }
        }

        void identity_bench(string opname, Func<ComparisonExpr,bit,bit,bit> checker, SystemCounter clock = default)
        {
            var opcount = 0;
            var sat = bit.On;

            clock.Start();
            for(var i=0; i<CycleCount; i++)
            {
                foreach(var expr in LogicIdentities.All)
                {
                    foreach(var c in bitcombo(2))
                    {
                        sat &= checker(expr, c[0], c[1]);
                        opcount++;
                    }
                }
            }
            clock.Stop();
            ReportBenchmark(opname, opcount,clock);
            Claim.require(sat);
        }
        
        void evaluator_bench()
            => identity_bench("identity/evaluator", LogicEngine.satisfied);
    }
}