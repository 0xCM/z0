//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static ConditionCodes;

    [StructLayout(LayoutKind.Sequential, Pack=1,Size=(int)SZ), Blittable(SZ)]
    public struct Jcc8Conditions
    {
        public const uint SZ = JccInfo<Jcc8>.SZ + JccInfo<Jcc8Alt>.SZ + 2*CharBlock64.SZ;

        public JccInfo<Jcc8> Primary;

        public JccInfo<Jcc8Alt> Alt;

        public CharBlock64 PrimaryInfo;

        public CharBlock64 AltInfo;

        public BitWidth RelWidth
        {
            [MethodImpl(Inline)]
            get => Primary.Size.Width;
        }

        public byte Encoding
        {
            [MethodImpl(Inline)]
            get => Primary.Encoding;
        }

        public ReadOnlySpan<char> EncodedBits
        {
            [MethodImpl(Inline)]
            get => BitRender.render8x4(Encoding);
        }

        public bit Identical
        {
            [MethodImpl(Inline)]
            get => Alt.Name == Primary.Name;
        }

        public string Format(bit alt)
            => Conditions.format(this,alt);

        public override string ToString()
            => Format(false);
    }
}