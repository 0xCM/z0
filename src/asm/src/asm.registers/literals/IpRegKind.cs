//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegWidth;
    using static RegisterBits;
    using static RegClass;

    /// <summary>
    /// Classifies instruction pointer registers
    /// </summary>
    public enum IpRegKind : uint
    {
        IP = IPTR << ClassField | W16 << WidthField,

        EIP = IPTR << ClassField | W32 << WidthField,

        RIP = IPTR << ClassField | W64 << WidthField,
    }
}