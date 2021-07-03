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
            public ushort A;

            public ushort B;

            public ushort C;

            public ushort D;

            public byte Count;

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Count == 0;
            }

            public static SectionNumber Empty => default;
        }
    }
}