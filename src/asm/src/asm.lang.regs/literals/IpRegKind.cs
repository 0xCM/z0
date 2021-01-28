//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegisterWidth;
    using static RegisterBits;
    using static RegisterClass;

    public enum IpRegKind : uint
    {
        IP = IPTR << ClassIndex | W16 << WidthIndex,

        EIP = IPTR << ClassIndex | W32 << WidthIndex,

        RIP = IPTR << ClassIndex | W64 << WidthIndex,
    }
}