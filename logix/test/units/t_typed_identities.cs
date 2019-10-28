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
    using BL = BitLogicSpec;
    using TL = TypedLogicSpec;
    // using static BitLogicSpec;
    // using static TypedLogicSpec;
    
    public class t_typed_identities : UnitTest<t_typed_identities>
    {
        public void check_scalar_identities()
        {
            iter(TypedIdentities.ScalarIdentities<byte>(), check_identity);
            iter(TypedIdentities.ScalarIdentities<ushort>(), check_identity);
            iter(TypedIdentities.ScalarIdentities<uint>(), check_identity);
            iter(TypedIdentities.ScalarIdentities<ulong>(), check_identity);
        }

        public void check_vec128_identities()
        {
            iter(TypedIdentities.Vec128Identities<byte>(), check_identity);
            iter(TypedIdentities.Vec128Identities<ushort>(), check_identity);
            iter(TypedIdentities.Vec128Identities<uint>(), check_identity);
            iter(TypedIdentities.Vec128Identities<ulong>(), check_identity);
        }

        public void check_vec256_identities()
        {
            iter(TypedIdentities.Vec256Identities<byte>(), check_identity);
            iter(TypedIdentities.Vec256Identities<ushort>(), check_identity);
            iter(TypedIdentities.Vec256Identities<uint>(), check_identity);
            iter(TypedIdentities.Vec256Identities<ulong>(), check_identity);
        }

        void check_identity<T>(ComparisonExpr<T> identity)
            where T :unmanaged
        {
            var @true = ScalarOps.@true<T>();
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                identity.SetVars(x,y);
                Claim.eq(TL.@true<T>(), LogicEngine.eval(identity)); 
                Claim.yea(LogicEngine.satisfied(identity, x, y));

            }
        }

        void check_identity<T>(ComparisonExpr<Vector128<T>> identity)
            where T :unmanaged
        {
            var @true = CpuOps.@true<T>(n128);
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector128<T>();
                var y = Random.CpuVector128<T>();
                identity.SetVars(x,y);

                Claim.eq(@true,LogicEngine.eval(identity).Value);   
                Claim.yea(LogicEngine.satisfied(identity, x,y));        
            }
        }

        void check_identity<T>(ComparisonExpr<Vector256<T>> equality)
            where T :unmanaged
        {
            var @true = CpuOps.@true<T>(n256);
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector256<T>();
                var y = Random.CpuVector256<T>();

                equality.SetVars(x,y);

                Claim.eq(@true, LogicEngine.eval(equality).Value);     
                Claim.yea(LogicEngine.satisfied(equality, x,y));
            }
        }
    }
}