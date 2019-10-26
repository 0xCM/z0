//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static nfunc;

    public class t_vpatterns : IntrinsicTest<t_vpatterns>
    {

        public void ones_pattern_128()
        {
            var n = n128;
            ones_pattern_check<byte>(n);            
            ones_pattern_check<ushort>(n);            
            ones_pattern_check<uint>(n);
            ones_pattern_check<ulong>(n);
            ones_pattern_check<sbyte>(n);            
            ones_pattern_check<short>(n);            
            ones_pattern_check<int>(n);
            ones_pattern_check<long>(n);
        }

        public void ones_pattern_256()
        {
            var n = n256;
            ones_pattern_check<byte>(n);            
            ones_pattern_check<ushort>(n);            
            ones_pattern_check<uint>(n);
            ones_pattern_check<ulong>(n);
            ones_pattern_check<sbyte>(n);            
            ones_pattern_check<short>(n);            
            ones_pattern_check<int>(n);
            ones_pattern_check<long>(n);
        }

        void ones_pattern_check<T>(N128 n = default)
            where T : unmanaged
        {
            var ones = ginx.vpOnes<T>(n);
            var bs = ones.ToBitString();
            Claim.eq(n,bs.Length);
            Claim.eq(n,bs.PopCount());
        }

        void ones_pattern_check<T>(N256 n = default)
            where T : unmanaged
        {
            var ones = ginx.vpOnes<T>(n);
            var bs = ones.ToBitString();
            Claim.eq(n,bs.Length);
            Claim.eq(n,bs.PopCount());
        }

 
    }


}