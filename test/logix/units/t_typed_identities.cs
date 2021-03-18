//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    using TL = TypedLogicSpec;

    public class t_typed_identities : t_logix<t_typed_identities>
    {
        public void check_scalar_identities()
        {
            root.iter(TypedIdentities.ScalarIdentities<byte>(), check_identity);
            root.iter(TypedIdentities.ScalarIdentities<ushort>(), check_identity);
            root.iter(TypedIdentities.ScalarIdentities<uint>(), check_identity);
            root.iter(TypedIdentities.ScalarIdentities<ulong>(), check_identity);
        }

        public void check_vec128_identities()
        {
            root.iter(TypedIdentities.Vec128Identities<byte>(), id => check_identity(n128,id));
            root.iter(TypedIdentities.Vec128Identities<ushort>(), id => check_identity(n128,id));
            root.iter(TypedIdentities.Vec128Identities<uint>(), id => check_identity(n128,id));
            root.iter(TypedIdentities.Vec128Identities<ulong>(), id => check_identity(n128,id));
        }

        public void check_vec256_identities()
        {
            root.iter(TypedIdentities.Vec256Identities<byte>(), id => check_identity(n256,id));
            root.iter(TypedIdentities.Vec256Identities<ushort>(), id => check_identity(n256,id));
            root.iter(TypedIdentities.Vec256Identities<uint>(), id => check_identity(n256,id));
            root.iter(TypedIdentities.Vec256Identities<ulong>(), id => check_identity(n256,id));
        }

        void check_identity<T>(ComparisonExpr<T> identity)
            where T :unmanaged
        {
            var @true = NumericLogixOps.@true<T>();
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                identity.SetVars(x,y);
                Claim.eq(TL.@true<T>(), LogicEngine.eval(identity));
                Claim.require(LogicEngine.satisfied(identity, x, y));

            }
        }

        void check_identity<T>(W128 w, ComparisonExpr<Vector128<T>> identity)
            where T :unmanaged
        {
            var @true = gcpu.vtrue<T>(w);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<T>(w);
                var y = Random.CpuVector<T>(w);
                identity.SetVars(x,y);

                Claim.veq(@true,LogicEngine.eval(identity).Value);
                Claim.require(LogicEngine.satisfied(identity, x,y));
            }
        }

        void check_identity<T>(W256 w, ComparisonExpr<Vector256<T>> equality)
            where T :unmanaged
        {
            var @true = gcpu.vtrue<T>(w);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<T>(w);
                var y = Random.CpuVector<T>(w);

                equality.SetVars(x,y);

                Claim.veq(@true, LogicEngine.eval(equality).Value);
                Claim.require(LogicEngine.satisfied(equality, x,y));
            }
        }
    }
}