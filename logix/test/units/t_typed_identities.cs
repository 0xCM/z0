//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static root;
    using static Nats;
    using TL = TypedLogicSpec;
    
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
            iter(TypedIdentities.Vec128Identities<byte>(), id => check_identity(n128,id));
            iter(TypedIdentities.Vec128Identities<ushort>(), id => check_identity(n128,id));
            iter(TypedIdentities.Vec128Identities<uint>(), id => check_identity(n128,id));
            iter(TypedIdentities.Vec128Identities<ulong>(), id => check_identity(n128,id));
        }

        public void check_vec256_identities()
        {
            iter(TypedIdentities.Vec256Identities<byte>(), id => check_identity(n256,id));
            iter(TypedIdentities.Vec256Identities<ushort>(), id => check_identity(n256,id));
            iter(TypedIdentities.Vec256Identities<uint>(), id => check_identity(n256,id));
            iter(TypedIdentities.Vec256Identities<ulong>(), id => check_identity(n256,id));
        }

        void check_identity<T>(ComparisonExpr<T> identity)
            where T :unmanaged
        {
            var @true = NumericOps.@true<T>();
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                identity.SetVars(x,y);
                Claim.eq(TL.@true<T>(), LogicEngine.eval(identity)); 
                Claim.require(LogicEngine.satisfied(identity, x, y));

            }
        }

        void check_identity<T>(N128 n, ComparisonExpr<Vector128<T>> identity)
            where T :unmanaged
        {
            var @true = VectorizedOps.@true<T>(n128);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<T>(n);
                var y = Random.CpuVector<T>(n);
                identity.SetVars(x,y);

                Claim.veq(@true,LogicEngine.eval(identity).Value);   
                Claim.require(LogicEngine.satisfied(identity, x,y));        
            }
        }

        void check_identity<T>(N256 n, ComparisonExpr<Vector256<T>> equality)
            where T :unmanaged
        {
            var @true = VectorizedOps.@true<T>(n);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<T>(n);
                var y = Random.CpuVector<T>(n);

                equality.SetVars(x,y);

                Claim.veq(@true, LogicEngine.eval(equality).Value);     
                Claim.require(LogicEngine.satisfied(equality, x,y));
            }
        }
    }
}