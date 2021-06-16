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
        /// <summary>
        /// Represents a section identifier of the form {a}.{b}.{c}.{d}
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct SectionNumber
        {
            public static SectionNumber Empty => default;

            public ushort A;

            public ushort B;

            public ushort C;

            public ushort D;

            [MethodImpl(Inline)]
            public SectionNumber(ushort a)
                : this()
            {
                A = a;
            }

            [MethodImpl(Inline)]
            public SectionNumber(ushort a, ushort b)
                : this()
            {
                A = a;
                B = b;
            }

            [MethodImpl(Inline)]
            public SectionNumber(ushort a, ushort b, ushort c)
                : this()
            {
                A = a;
                B = b;
                C = c;
            }

            [MethodImpl(Inline)]
            public SectionNumber(ushort a, ushort b, ushort c, ushort d)
                : this()
            {
                A = a;
                B = b;
                C = c;
                D = d;
            }

            public byte Count
            {
                [MethodImpl(Inline)]
                get => (byte)(core.u8(A !=0) + core.u8(B != 0) + core.u8(C != 0) + core.u8(D != 0));
            }
        }
    }
}