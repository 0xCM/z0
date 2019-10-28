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
    using System.Reflection;
    using static zfunc;
    using static TypedLogicSpec;

    public class t_solve : UnitTest<t_solve>
    {
        public void solve_and_over_or_u32_1var()
        {
            var identity = TypedIdentities.AndOverOr<uint>();
            identity.SetVar(0, 32u);
            var sln = LogicEngine.solve(identity, (0u,255u),1);
            Claim.eq(256,sln.Count);        
        }

        public void solve_and_over_or_u32_2vars()
            => check_identity_sln(TypedIdentities.AndOverOr<uint>(), 0u,30u);

        public void solve_and_over_or_u64_2vars()
            => check_identity_sln(TypedIdentities.AndOverOr<ulong>(), 0ul,30ul);

        public void solve_not_over_xor_u32_2vars()
            => check_identity_sln(TypedIdentities.NotOverXOr<uint>(), 0u,30u);

        public void solve_not_over_xor_u8_2vars()
            => check_identity_sln(TypedIdentities.NotOverXOr<byte>(), (byte)0,(byte)30);


        void check_identity_sln<T>(ComparisonExpr<T> identity, T min, T max)
            where T : unmanaged
        {
            var count = convert<T,int>(gmath.add(gmath.sub(max, min), gmath.one<T>()));
            var expect = gmath.square(count);
            var sln = LogicEngine.solve(identity, (min,max));
            Claim.eq(expect,sln.Count);            
        }

    }

}