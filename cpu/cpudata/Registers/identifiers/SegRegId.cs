//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    /// <summary>
    /// Classifies the segment registers
    /// </summary>
    [Flags]
    public enum SegRegId : ulong
    {

        cs,

        ds,

        fs,

        gs,

        ss


    }

}