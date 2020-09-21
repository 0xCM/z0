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
    public enum ParamFlags : ushort
    {
        InSemantics = 0x0001,

        OutSemantics = 0x0002,

        OptionalSemantics = 0x0010,

        HasDefaultReserved = 0x1000,

        HasFieldMarshalReserved = 0x2000,

        //  Comes from signature...
        ByReference = 0x0100,

        ParamArray = 0x0200,
    }
}