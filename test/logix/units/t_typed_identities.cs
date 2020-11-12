//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;
    using TL = TypedLogicSpec;

    public class t_typed_identities : LogixTest<t_typed_identities>
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
            var @true = NumericLogix.@true<T>();
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                identity.SetVars(x,y);
                Claim.Eq(TL.@true<T>(), LogicEngine.eval(identity));
                Claim.Require(LogicEngine.satisfied(identity, x, y));

            }
        }

        void check_identity<T>(W128 w, ComparisonExpr<Vector128<T>> identity)
            where T :unmanaged
        {
            var @true = gvec.vtrue<T>(w);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<T>(w);
                var y = Random.CpuVector<T>(w);
                identity.SetVars(x,y);

                Claim.veq(@true,LogicEngine.eval(identity).Value);
                Claim.Require(LogicEngine.satisfied(identity, x,y));
            }
        }

        void check_identity<T>(W256 w, ComparisonExpr<Vector256<T>> equality)
            where T :unmanaged
        {
            var @true = gvec.vtrue<T>(w);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<T>(w);
                var y = Random.CpuVector<T>(w);

                equality.SetVars(x,y);

                Claim.veq(@true, LogicEngine.eval(equality).Value);
                Claim.Require(LogicEngine.satisfied(equality, x,y));
            }
        }
    }
}