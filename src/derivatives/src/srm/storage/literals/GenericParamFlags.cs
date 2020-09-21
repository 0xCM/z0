//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Runtime.InteropServices;

    using static Part;

    [Flags]
    public enum GenericParamFlags : ushort
    {
        NonVariant = 0x0000,

        Covariant = 0x0001,

        Contravariant = 0x0002,

        VarianceMask = 0x0003,

        ReferenceTypeConstraint = 0x0004,

        ValueTypeConstraint = 0x0008,

        DefaultConstructorConstraint = 0x0010,
    }

}