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

    using static BitLogicSpec;
    using static TypedLogicSpec;
    
    public class t_typed_identities : UnitTest<t_typed_identities>
    {
        public void check_scalar_identities()
        {
            iter(TypedIdentities.ScalarIdentities<byte>(), check_samples);
            iter(TypedIdentities.ScalarIdentities<ushort>(), check_samples);
            iter(TypedIdentities.ScalarIdentities<uint>(), check_samples);
            iter(TypedIdentities.ScalarIdentities<ulong>(), check_samples);
        }

        public void check_vec128_identities()
        {
            iter(TypedIdentities.Vec128Identities<byte>(), check_samples);
            iter(TypedIdentities.Vec128Identities<ushort>(), check_samples);
            iter(TypedIdentities.Vec128Identities<uint>(), check_samples);
            iter(TypedIdentities.Vec128Identities<ulong>(), check_samples);
        }

        public void check_vec256_identities()
        {
            iter(TypedIdentities.Vec256Identities<byte>(), check_samples);
            iter(TypedIdentities.Vec256Identities<ushort>(), check_samples);
            iter(TypedIdentities.Vec256Identities<uint>(), check_samples);
            iter(TypedIdentities.Vec256Identities<ulong>(), check_samples);
        }

        void check_samples<T>(EqualityExpr<T> equality)
            where T :unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                equality.SetVars(x,y);
                Claim.eq(@true<T>(), LogicEngine.eval(equality)); 
                Claim.yea(LogicEngine.satisfied(equality, x, y));

            }
        }

        void check_samples<T>(EqualityExpr<Vector128<T>> equality)
            where T :unmanaged
        {
            var @true = literal(ginx.vones<T>(n128));
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector128<T>();
                var y = Random.CpuVector128<T>();
                equality.SetVars(x,y);

                Claim.eq(@true.Value,LogicEngine.eval(equality).Value);   
                Claim.yea(LogicEngine.satisfied(equality, x,y));        
            }
        }

        void check_samples<T>(EqualityExpr<Vector256<T>> equality)
            where T :unmanaged
        {
            var @true = literal(ginx.vones<T>(n256));
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector256<T>();
                var y = Random.CpuVector256<T>();

                equality.SetVars(x,y);

                Claim.eq(@true.Value, LogicEngine.eval(equality).Value);     
                Claim.yea(LogicEngine.satisfied(equality, x,y));
            }
        }
    }
}