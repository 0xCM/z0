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

        public void vones_128()
        {
            var n = n128;
            vones_check<byte>(n);            
            vones_check<ushort>(n);            
            vones_check<uint>(n);
            vones_check<ulong>(n);
            vones_check<sbyte>(n);            
            vones_check<short>(n);            
            vones_check<int>(n);
            vones_check<long>(n);
        }

        public void vones_256()
        {
            var n = n256;
            vones_check<byte>(n);            
            vones_check<ushort>(n);            
            vones_check<uint>(n);
            vones_check<ulong>(n);
            vones_check<sbyte>(n);            
            vones_check<short>(n);            
            vones_check<int>(n);
            vones_check<long>(n);
        }

        void vones_check<T>(N128 n)
            where T : unmanaged
        {
            var ones = ginx.vones<T>(n);
            var bs = ones.ToBitString();
            Claim.eq(n,bs.Length);
            Claim.eq(n,bs.PopCount());
        }

        void vones_check<T>(N256 n)
            where T : unmanaged
        {
            var ones = ginx.vones<T>(n);
            var bs = ones.ToBitString();
            Claim.eq(n,bs.Length);
            Claim.eq(n,bs.PopCount());
        }

    }

}