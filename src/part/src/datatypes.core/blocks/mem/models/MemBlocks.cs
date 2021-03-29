//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class MemBlocks
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Block1
        {
            byte A;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block2
        {
            Block1 A;

            Block1 B;
        }

        /// <summary>
        /// 3 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block3
        {
            Block2 A;

            Block1 B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block4
        {
            Block2 A;

            Block2 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        /// <summary>
        /// 5 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block5
        {
            Block4 A;

            Block1 B;
        }

        /// <summary>
        /// 6 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block6
        {
            Block5 A;

            Block1 B;
        }

        /// <summary>
        /// 7 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block7
        {
            Block6 A;

            Block1 B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block8
        {
            Block4 A;

            Block4 B;
        }

        /// <summary>
        /// 9 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block9
        {
            Block8 A;

            Block1 B;
        }

        /// <summary>
        /// 10 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block10
        {
            Block9 A;

            Block1 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        /// <summary>
        /// 11 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block11
        {
            Block10 A;

            Block1 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        /// <summary>
        /// 12 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block12
        {
            Block8 A;

            Block4 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        /// <summary>
        /// 13 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block13
        {
            Block12 A;

            Block1 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        /// <summary>
        /// 14 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block14
        {
            Block7 A;

            Block7 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }

        }

        /// <summary>
        /// 15 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block15
        {
            public Block10 A;

            public Block5 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }

        }

        /// <summary>
        /// Defines 16 bytes = 512 bits of stack-allocated storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block16
        {
            public ulong X0;

            public ulong X1;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        /// <summary>
        /// Covers 32 bytes = 256 bits of stack-allocated storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block32
        {
            Block16 A;

            Block16 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        /// <summary>
        /// Covers 64 bytes = 512 bits of stack-allocated storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block64
        {
            Block32 A;

            Block32 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        /// <summary>
        /// Covers 128 bytes = 1024 bits of stack-allocated storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block128
        {
            internal Block64 A;

            internal Block64 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        public struct Block01<T>
            where T : unmanaged
        {
            T Data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block02<T>
            where T : unmanaged
        {
            Block01<T> A;

            Block01<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block03<T>
            where T : unmanaged
        {
            Block01<T> A;

            Block02<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block04<T>
            where T : unmanaged
        {
            Block02<T> A;

            Block02<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block05<T>
            where T : unmanaged
        {
            Block04<T> A;

            Block01<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block06<T>
            where T : unmanaged
        {
            Block03<T> A;

            Block03<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block07<T>
            where T : unmanaged
        {
            Block06<T> A;

            Block01<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block08<T>
            where T : unmanaged
        {
            Block04<T> Cell0;

            Block04<T> Cell1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block12<T>
            where T : unmanaged
        {
            Block06<T> Cell0;

            Block06<T> Cell1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block16<T>
            where T : unmanaged
        {
            Block08<T> Cell0;

            Block08<T> Cell1;
        }
    }
}