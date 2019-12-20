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
    
    using static zfunc;

    public class t_cpuid : UnitTest<t_cpuid>
    {

        public void VerifyStructure()
        {
            var features = CpuFeatureSet.Ecx(0);
            features[CpuIdEcx.PCLMULQDQ] = true;
            features[CpuIdEcx.SSE3] = true;
            features[CpuIdEcx.MONITOR] = true;

            Claim.yea(features.Test(CpuIdEcx.PCLMULQDQ));
            Claim.yea(features.Test(CpuIdEcx.SSE3));
            Claim.yea(features.Test(CpuIdEcx.MONITOR));
            Claim.nea(features.Test(CpuIdEcx.DS_CPL));        

            // var bits = features.GetEnabled();
            // Claim.eq(3,bits.Length);
            // Claim.yea(bits.Contains(CpuIdEcx.PCLMULQDQ));
            // Claim.yea(bits.Contains(CpuIdEcx.SSE3));
            // Claim.yea(bits.Contains(CpuIdEcx.MONITOR));
            // Claim.nea(bits.Contains(CpuIdEcx.DS_CPL));        
        }
    }
}