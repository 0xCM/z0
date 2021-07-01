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
            public const string Descriptor = "Vol. {Major}{Minor}";

            public const string RenderPattern = "Vol. {0}{1}";

            public byte Major;

            public AsciCode Minor;

            [MethodImpl(Inline)]
            public VolNumber(byte major, AsciCode minor)
            {
                Major = major;
                Minor = minor;
            }

            public string Format()
                => string.Format(RenderPattern, Major, (char)Minor);

            public override string ToString()
                => Format();

            public static implicit operator string (VolNumber src)
                => src.Format();
        }
    }
}