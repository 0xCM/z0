//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct IntelSdm
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct VolNumber
        {
            public byte Major;

            public AsciCode Minor;

            [MethodImpl(Inline)]
            public VolNumber(byte major, AsciCode minor)
            {
                Major = major;
                Minor = minor;
            }
        }
    }
}