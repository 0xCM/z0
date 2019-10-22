//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    using static LogicEngine;
    using static BitLogicSpec;
    using static TypedLogicSpec;
    
    


    public class t_identity_typed : UnitTest<t_identity_typed>
    {
        public void check_not_over_and_64u()
            => check_samples(TypedIdentities.NotOverAnd<ulong>());

        public void check_not_over_xor_64u()
            => check_samples(TypedIdentities.NotOverXOr<ulong>());

        public void check_and_over_or_64u()
            => check_samples(TypedIdentities.AndOverOr<ulong>());

        public void check_and_over_xor_64u()
            => check_samples(TypedIdentities.AndOverXOr<ulong>());

        public void check_or_over_and_64u()
            => check_samples(TypedIdentities.OrOverAnd<ulong>());

        public void check_not_over_and_128x64u()
            => check_samples(TypedIdentities.NotOverAnd128<ulong>());

        public void check_not_over_xor_128x64u()
            => check_samples(TypedIdentities.NotOverXOr128<ulong>());

        public void check_and_over_or_128x64u()
            => check_samples(TypedIdentities.AndOverOr128<ulong>());

        public void check_and_over_xor_128x64u()
            => check_samples(TypedIdentities.AndOverXOr128<ulong>());

        public void check_or_over_and_128x64u()
            => check_samples(TypedIdentities.OrOverAnd128<ulong>());

        public void check_not_over_and_256x64u()
            => check_samples(TypedIdentities.NotOverAnd256<ulong>());

        public void check_not_over_xor_256x64u()
            => check_samples(TypedIdentities.NotOverXOr256<ulong>());

        public void check_and_over_or_256x64u()
            => check_samples(TypedIdentities.AndOverOr256<ulong>());

        public void check_and_over_xor_256x64u()
            => check_samples(TypedIdentities.AndOverXOr256<ulong>());
        
        public void check_or_over_and_256x64u()
            => check_samples(TypedIdentities.OrOverAnd256<ulong>());

        void check_samples<T>(EqualityExpr<T> equality)
            where T :unmanaged
        {
            //Trace(t.Format());
            for(var i=0; i<SampleSize; i++)
            {
                var vars = Random.Array<T>(equality.Vars.Length);
                equality.SetVars(vars);
                Claim.eq(@true<T>(), LogicEngine.eval(equality)); 
                Claim.yea(LogicEngine.satisfied(equality, vars[0], vars[1]));

            }
        }

        void check_samples<T>(EqualityExpr<Vector128<T>> equality)
            where T :unmanaged
        {
            var @true = literal(ginx.vones<T>(n128));
            for(var i=0; i<SampleSize; i++)
            {
                var vars = Random.CpuVectors128<T>().Take(equality.Vars.Length).ToArray();
                equality.SetVars(vars);
                var result = LogicEngine.eval(equality);

                Claim.eq(@true.Value,LogicEngine.eval(equality).Value);   
                Claim.yea(LogicEngine.satisfied(equality, vars[0],vars[1]));
         
            }
        }

        void check_samples<T>(EqualityExpr<Vector256<T>> equality)
            where T :unmanaged
        {
            var @true = literal(ginx.vones<T>(n256));
            for(var i=0; i<SampleSize; i++)
            {
                var vars = Random.CpuVectors256<T>().Take(equality.Vars.Length).ToArray();
                equality.SetVars(vars);
                var result = LogicEngine.eval(equality);

                Claim.eq(@true.Value, LogicEngine.eval(equality).Value);     
                Claim.yea(LogicEngine.satisfied(equality, vars[0],vars[1]));

            }
        }

    }
}