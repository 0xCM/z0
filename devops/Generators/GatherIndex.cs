//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class GatherIndex
    {

    //    public static IEnumerable<string> IndexVectors
    //    {
    //         get
    //         {
    //             var hv256 = Vector256.Create(Pow2.T00 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1);
    //             var hv256Data = hv256.ToSpan().FormatHexProp("VGather256x64x256IndexData", hv256.Format());
    //             yield return hv256Data;

    //             var hv512 = Vector256.Create(0, Pow2.T03 - 1, Pow2.T04 - 1, Pow2.T05 - 1, Pow2.T06 - 1, Pow2.T07 - 1, Pow2.T08 - 1, Pow2.T09 - 1);
    //             var hv512Data = hv512.ToSpan().FormatHexProp("VGather256x32x512IndexData", hv512.Format());
    //             yield return hv512Data;

    //         }
    //    }
    }
}