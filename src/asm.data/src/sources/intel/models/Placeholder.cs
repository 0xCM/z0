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
        /// Represents a sequence of placeholder markers, each of the form ' .'
        /// </summary>
        public struct Placeholder
        {
            public static Placeholder One => new Placeholder(1);

            public static Placeholder Empty => new Placeholder(0);

            public const char Part1 = ' ';

            public const char Part2 = '.';

            public byte Count;

            [MethodImpl(Inline)]
            public Placeholder(byte count)
            {
                Count = count;
            }

            public byte Length
            {
                [MethodImpl(Inline)]
                get => (byte)(Count * 2);
            }

            public ByteSize Size
            {
                [MethodImpl(Inline)]
                get => Length;
            }

            [MethodImpl(Inline)]
            public static implicit operator Placeholder(byte count)
                => new Placeholder(count);

            [MethodImpl(Inline)]
            public static implicit operator Placeholder(int count)
                => new Placeholder((byte)count);
        }
    }
}