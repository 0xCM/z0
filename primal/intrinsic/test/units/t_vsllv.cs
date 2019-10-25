//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class t_vsllv : IntrinsicTest<t_vsllv>
    {

        public void Nonzero()
        {
            Claim.yea(ginx.nonz(Vec256.FromParts(1ul, 2ul, 3ul, 4ul)));
            Claim.yea(ginx.nonz(Vec256.FromParts(1ul, 0ul, 0ul, 0ul)));
            Claim.nea(ginx.nonz(Vec256.FromParts(0ul, 0ul, 0ul, 0ul)));

            Claim.yea(ginx.vnonz(Vec128.FromParts(1u, 2u, 3u, 4u)));
            Claim.yea(ginx.vnonz(Vec128.FromParts(1u, 0u, 0u, 0u)));
            Claim.nea(ginx.vnonz(Vec128.FromParts(0u, 0u, 0u, 0u)));
        }

        // public void vsllv_256x32u()
        // {
        //     var src = Random.CpuVec256<uint>();
        //     var shifts = Random.CpuVec256<uint>(closed(1u,7u));  

        //     var expect = src.ToSpan256();
        //     for(var i = 0; i < src.Length(); i ++)
        //         expect[i] = gmath.sal(src[i], (int)shifts[i]);
            
        //     var v1 = expect.LoadVec256();
        //     var v2 = ginx.vsllv(src, shifts);            

        //     Claim.eq(v1,v2);            
        // }
        
        // public void vsslv_128x32u()
        // {
        //     var src = Random.CpuVector128<uint>();
        //     var shifts = Random.CpuVector128<uint>(closed(1u,7u));            

        //     var expect = src.ToSpan128();
        //     for(var i = 0; i < src.Length(); i ++)
        //         expect[i] = gmath.sal(src[i], (int)shifts[i]);
            
        //     var v1 = expect.LoadVec128();
        //     var v2 = ginx.vsllv(src, shifts);            

        //     Claim.eq(v1,v2);            
        // }

        // public void vsllv_128x64u()
        // {
        //     var src = Random.CpuVec128<ulong>();
        //     var shifts = Random.CpuVec128<ulong>(closed(1ul,7ul));            

        //     var expect = src.ToSpan128();
        //     for(var i = 0; i < src.Length(); i ++)
        //         expect[i] = gmath.sal(src[i], (int)shifts[i]);
            
        //     var v1 = expect.LoadVec128();
        //     var v2 = ginx.vsllv(src, shifts);            

        //     Claim.eq(v1,v2);            
        // }

        // public void vsllv_256x64()
        // {
        //     var src = Random.CpuVec256<ulong>();
        //     var shifts = Random.CpuVec256<ulong>(closed(1ul,7ul));            
            
        //     var expect = src.ToSpan256();
        //     for(var i = 0; i < src.Length(); i ++)
        //         expect[i] = gmath.sal(src[i], (int)shifts[i]);
            
        //     var v1 = expect.LoadVec256();
        //     var v2 = ginx.vsllv(src, shifts);            

        //     Claim.eq(v1,v2);            
        // }

    }

}