//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.CpuModel
{
    using System;


    /// <summary>
    /// Classifies the segment registers
    /// </summary>
    [Flags]
    public enum SegRegId : ulong
    {

        es = 0,

        cs = es + 1,

        ss = cs + 1,

        ds = ss + 1,

        fs = ds + 1,

        gs = fs + 1,



    }

}