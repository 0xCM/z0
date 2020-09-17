//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;

    partial struct ClrStorage
    {
        //  0x07
        [StructLayout(LayoutKind.Sequential)]
        public struct ParamPtrRow
        {
            public uint Param;

        }



    }

}