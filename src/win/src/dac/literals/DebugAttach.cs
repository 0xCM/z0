//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;

    [Flags]
    public enum DebugAttach : uint
    {
        Default = 0,
        
        NonInvasive = 1,
    }
}