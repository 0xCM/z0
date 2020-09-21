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
    public enum MethodSemanticsFlags : ushort
    {
        Setter = 0x0001,

        Getter = 0x0002,

        Other = 0x0004,

        AddOn = 0x0008,

        RemoveOn = 0x0010,

        Fire = 0x0020,
    }
}