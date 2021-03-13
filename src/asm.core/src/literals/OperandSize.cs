//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public enum OperandSize : byte
    {
        W16 = (byte)DataWidth.W16,

        W32 = (byte)DataWidth.W32,

        W64 = (byte)DataWidth.W64
    }
}