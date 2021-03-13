//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [Flags]
    public enum OperandSizeDefault : byte
    {
        None = 0,

        Mode64 = OperandSize.W32,

        Compatibility = OperandSize.W16 | OperandSize.W32,

        Legacy = OperandSize.W16 | OperandSize.W32,
    }
}