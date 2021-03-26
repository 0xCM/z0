//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;


    partial class MemBlocks
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock1
        {
            byte A;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock2
        {
            MemBlock1 A;

            MemBlock1 B;
        }

        /// <summary>
        /// 3 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock3
        {
            MemBlock2 A;

            MemBlock1 B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock4
        {
            MemBlock2 A;

            MemBlock2 B;
        }

        /// <summary>
        /// 5 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock5
        {
            MemBlock4 A;

            MemBlock1 B;
        }

        /// <summary>
        /// 6 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock6
        {
            MemBlock5 A;

            MemBlock1 B;
        }

        /// <summary>
        /// 7 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock7
        {
            public MemBlock6 A;

            public MemBlock1 B;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock8
        {
            MemBlock4 A;

            MemBlock4 B;
        }

        /// <summary>
        /// 9 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock9
        {
            MemBlock8 A;

            MemBlock1 B;
        }

        /// <summary>
        /// 10 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock10
        {
            MemBlock9 A;

            MemBlock1 B;
        }

        /// <summary>
        /// 11 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock11
        {
            MemBlock10 A;

            MemBlock1 B;
        }

        /// <summary>
        /// 12 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock12
        {
            MemBlock8 A;

            MemBlock4 B;
        }

        /// <summary>
        /// 13 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock13
        {
            MemBlock12 A;

            MemBlock1 B;
        }

        /// <summary>
        /// 14 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock14
        {
            MemBlock7 A;

            MemBlock7 B;
        }


        /// <summary>
        /// 15 bytes of storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock15
        {
            public MemBlock10 A;

            public MemBlock5 B;
        }


        /// <summary>
        /// Defines 16 bytes = 512 bits of stack-allocated storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock16
        {
            public ulong X0;

            public ulong X1;
        }

        /// <summary>
        /// Covers 32 bytes = 256 bits of stack-allocated storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock32
        {
            MemBlock16 A;

            MemBlock16 B;
        }

        /// <summary>
        /// Covers 64 bytes = 512 bits of stack-allocated storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock64
        {
            MemBlock32 A;

            MemBlock32 B;
        }

        /// <summary>
        /// Covers 128 bytes = 1024 bits of stack-allocated storage
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MemBlock128
        {
            internal MemBlock64 A;

            internal MemBlock64 B;
        }
    }
}