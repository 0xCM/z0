//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static RegClasses;

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<RegOp> list(GpClass @class)
            => recover<RegOp>(GpRegData);

        static ReadOnlySpan<byte> GpRegData
            => new byte[128]{0x23,0x00,0x22,0x00,0x21,0x00,0x20,0x00,0x23,0x04,0x22,0x04,0x21,0x04,0x20,0x04,0x23,0x08,0x22,0x08,0x21,0x08,0x20,0x08,0x23,0x0c,0x22,0x0c,0x21,0x0c,0x20,0x0c,0x23,0x10,0x22,0x10,0x21,0x10,0x20,0x10,0x23,0x14,0x22,0x14,0x21,0x14,0x20,0x14,0x23,0x18,0x22,0x18,0x21,0x18,0x20,0x18,0x23,0x1c,0x22,0x1c,0x21,0x1c,0x20,0x1c,0x23,0x20,0x22,0x20,0x21,0x20,0x20,0x20,0x23,0x24,0x22,0x24,0x21,0x24,0x20,0x24,0x23,0x28,0x22,0x28,0x21,0x28,0x20,0x28,0x23,0x2c,0x22,0x2c,0x21,0x2c,0x20,0x2c,0x23,0x30,0x22,0x30,0x21,0x30,0x20,0x30,0x23,0x34,0x22,0x34,0x21,0x34,0x20,0x34,0x23,0x38,0x22,0x38,0x21,0x38,0x20,0x38,0x23,0x3c,0x22,0x3c,0x21,0x3c,0x20,0x3c};
    }
}