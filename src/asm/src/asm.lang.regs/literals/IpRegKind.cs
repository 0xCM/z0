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
        IP = IPTR << ClassIndex | W16 << WidthIndex,

        EIP = IPTR << ClassIndex | W32 << WidthIndex,

        RIP = IPTR << ClassIndex | W64 << WidthIndex,
    }
}