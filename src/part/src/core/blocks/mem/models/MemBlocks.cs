//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial class MemBlocks
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Block1 : IMemBlock<Block1>
        {
            public const byte Size = 1;

            byte A;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block2 : IMemBlock<Block2>
        {
            public const byte Size = 2;

            Block1 A;

            Block1 B;
        }

        /// <summary>
        /// 3 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block3 : IMemBlock<Block3>
        {
            public const byte Size = 3;

            Block2 A;

            Block1 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block4 : IMemBlock<Block4>
        {
            public const byte Size = 4;

            Block2 A;

            Block2 B;

            [MethodImpl(Inline)]
            public static implicit operator Block4(uint src)
                => memory.@as<uint,Block4>(src);

            [MethodImpl(Inline)]
            public static implicit operator uint(Block4 src)
                => memory.@as<Block4,uint>(src);

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
        public struct Block5 : IMemBlock<Block5>
        {
            public const byte Size = 5;

            Block4 A;

            Block1 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        /// <summary>
        /// 6 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block6 : IMemBlock<Block6>
        {
            public const byte Size = 6;

            Block5 A;

            Block1 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }

            /// <summary>
            /// Specifies a reference to the leading cell
            /// </summary>
            public ref byte First
            {
                [MethodImpl(Inline)]
                get => ref memory.first(Bytes);
            }

        }

        /// <summary>
        /// 7 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block7 : IMemBlock<Block7>
        {
            public const byte Size = 7;

            Block6 A;

            Block1 B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block8 : IMemBlock<Block8>
        {
            public const byte Size = 8;

            Block4 A;

            Block4 B;

            [MethodImpl(Inline)]
            public Block8(uint a, uint b)
            {
                A = a;
                B = b;
            }

            [MethodImpl(Inline)]
            public Block8(Block4 a, Block4 b)
            {
                A = a;
                B = b;
            }

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }

            [MethodImpl(Inline)]
            public static implicit operator Block8(ulong src)
                => memory.@as<ulong,Block8>(src);

            [MethodImpl(Inline)]
            public static implicit operator ulong(Block8 src)
                => memory.@as<Block8,ulong>(src);
        }

        /// <summary>
        /// 9 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block9 : IMemBlock<Block9>
        {
            public const byte Size = 9;

            Block8 A;

            Block1 B;
        }

        /// <summary>
        /// 10 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block10 : IMemBlock<Block10>
        {
            public const byte Size = 10;

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
        public struct Block11 : IMemBlock<Block11>
        {
            public const byte Size = 11;

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
        public struct Block12 : IMemBlock<Block12>
        {
            public const byte Size = 12;

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
        public struct Block13 : IMemBlock<Block13>
        {
            public const byte Size = 13;

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
        public struct Block14 : IMemBlock<Block14>
        {
            public const byte Size = 14;

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
        public struct Block15 : IMemBlock<Block15>
        {
            public const byte Size = 15;

            Block10 A;

            Block5 B;

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
        public struct Block16 : IMemBlock<Block16>
        {
            public const byte Size = 16;

            public ulong A;

            public ulong B;

            [MethodImpl(Inline)]
            public Block16(ulong a, ulong b)
            {
                A = a;
                B = b;
            }

            [MethodImpl(Inline)]
            public Block16(Block8 a, Block8 b)
            {
                A = a;
                B = b;
            }

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block17 : IMemBlock<Block17>
        {
            public const byte Size = 17;

            Block16 A;

            Block1 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block18 : IMemBlock<Block18>
        {
            public const byte Size = 18;

            Block16 A;

            Block2 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block19 : IMemBlock<Block19>
        {
            public const byte Size = 19;

            Block16 A;

            Block3 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block20 : IMemBlock<Block20>
        {
            public const byte Size = 20;

            Block16 A;

            Block4 B;


            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block24 : IMemBlock<Block24>
        {
            public const byte Size = 24;

            Block16 A;

            Block8 B;

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
        public struct Block32 : IMemBlock<Block32>
        {
            public const byte Size = 32;

            Block16 A;

            Block16 B;

            [MethodImpl(Inline)]
            public Block32(Block16 a, Block16 b)
            {
                A = a;
                B = b;
            }

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        /// <summary>
        /// Covers 64 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block64 : IMemBlock<Block64>
        {
            public const byte Size = 64;

            Block32 A;

            Block32 B;


            [MethodImpl(Inline)]
            public Block64(Block32 a, Block32 b)
            {
                A = a;
                B = b;
            }

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        /// <summary>
        /// Covers 64 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Block80 : IMemBlock<Block80>
        {
            public const byte Size = 80;

            Block64 A;

            Block18 B;

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
            public const byte Size = 128;

            internal Block64 A;

            internal Block64 B;

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => span<byte>(ref this);
            }
        }

        public struct Block01<T> : IMemBlock<Block01<T>>
            where T : unmanaged
        {
            T Data;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block02<T> : IMemBlock<Block02<T>>
            where T : unmanaged
        {
            Block01<T> A;

            Block01<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block03<T> : IMemBlock<Block03<T>>
            where T : unmanaged
        {
            Block01<T> A;

            Block02<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block04<T> : IMemBlock<Block04<T>>
            where T : unmanaged
        {
            Block02<T> A;

            Block02<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block05<T> : IMemBlock<Block05<T>>
            where T : unmanaged
        {
            Block04<T> A;

            Block01<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block06<T> : IMemBlock<Block06<T>>
            where T : unmanaged
        {
            Block03<T> A;

            Block03<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block07<T> : IMemBlock<Block07<T>>
            where T : unmanaged
        {
            Block06<T> A;

            Block01<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block08<T> : IMemBlock<Block08<T>>
            where T : unmanaged
        {
            Block04<T> A;

            Block04<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block12<T> : IMemBlock<Block12<T>>
            where T : unmanaged
        {
            Block06<T> A;

            Block06<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block16<T> : IMemBlock<Block16<T>>
            where T : unmanaged
        {
            Block08<T> A;

            Block08<T> B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Block32<T> : IMemBlock<Block32<T>>
            where T : unmanaged
        {
            Block16<T> Cell0;

            Block16<T> Cell1;
        }
    }
}