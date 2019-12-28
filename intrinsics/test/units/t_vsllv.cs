//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vsllv : t_vinx<t_vsllv>
    {
        void vsllv_check(N128 w = default)
        {
            //check_scalar_match(VOps.vsllv<sbyte>(w), TestCase128<sbyte>);
            //check_scalar_match(VOps.vsllv<short>(w), TestCase128<short>);

            CheckScalarMatch(VX.vsllv<byte>(w), TestCase128<byte>);
            CheckScalarMatch(VX.vsllv<ushort>(w), TestCase128<ushort>);
            CheckScalarMatch(VX.vsllv<int>(w), TestCase128<int>);
            CheckScalarMatch(VX.vsllv<uint>(w), TestCase128<uint>);
            CheckScalarMatch(VX.vsllv<long>(w), TestCase128<long>);
            CheckScalarMatch(VX.vsllv<ulong>(w), TestCase128<ulong>);
        }

        void vsllv_check(N256 w = default)
        {
            //check_scalar_match(VOps.vsllv<sbyte>(w), TestCase256<sbyte>);
            //check_scalar_match(VOps.vsllv<short>(w), TestCase256<short>);

            CheckScalarMatch(VX.vsllv<byte>(w), TestCase256<byte>);
            CheckScalarMatch(VX.vsllv<ushort>(w), TestCase256<ushort>);
            CheckScalarMatch(VX.vsllv<int>(w), TestCase256<int>);
            CheckScalarMatch(VX.vsllv<uint>(w), TestCase256<uint>);
            CheckScalarMatch(VX.vsllv<long>(w), TestCase256<long>);
            CheckScalarMatch(VX.vsllv<ulong>(w), TestCase256<ulong>);
        }

        public void vsllv_check()
        {
            vsllv_check(n128);
            vsllv_check(n256);
        }

        [MethodImpl(Inline)]
        Pair<Vector128<T>> TestCase128<T>(int i)
            where T : unmanaged        
        {
            var t = default(T);
            var w = n128;
            var x = Random.CpuVector<T>(w);
            var bounds = (gmath.zero(t), convert<int,T>(bitsize(t) - 1));
            var offsets = Random.CpuVector<T>(w, bounds);
            return (x,offsets);            
        }

        [MethodImpl(Inline)]
        Pair<Vector256<T>> TestCase256<T>(int i)
            where T : unmanaged        
        {
            var t = default(T);
            var w = n256;
            var x = Random.CpuVector<T>(w);
            var bounds = (gmath.zero(t), convert<int,T>(bitsize(t) - 1));
            var offsets = Random.CpuVector<T>(w, bounds);
            return (x,offsets);            
        }
    }
}