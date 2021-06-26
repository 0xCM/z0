//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines <see cref='RegWidth'/> bitfield codes
    /// </summary>
    public enum RegWidthIndex : byte
    {
        W8 = 0,

        W16 = 1,

        W32 = 2,

        W64 = 3,

        W128 = 4,

        W256 = 5,

        W512 = 6
    }
}
