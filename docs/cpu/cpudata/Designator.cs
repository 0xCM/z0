//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Root;


    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class CpuData : AssemblyDesignator<CpuData>
    {
        public override AssemblyRole Role 
            => AssemblyRole.Library;
    }
}