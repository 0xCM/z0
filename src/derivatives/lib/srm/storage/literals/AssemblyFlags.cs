//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;

    [Flags]
    public enum AssemblyFlags : uint
    {
        PublicKey = 0x00000001,

        Retargetable = 0x00000100,

        ContainsForeignTypes = 0x00000200
    }
}