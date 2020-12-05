//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class MemoryStacks
    {
        /// <summary>
        /// 1 byte of storage
        /// </summary>
        public struct StackBlock1
        {
            public Cell8 Data;
        }

        /// <summary>
        /// 2 bytes of storage
        /// </summary>
        public struct StackBlock2
        {
            public StackBlock1 Lo;

            public StackBlock1 Hi;
        }

        /// <summary>
        /// 3 bytes of storage
        /// </summary>
        public struct StackBlock3
        {
            public StackBlock2 A;

            public StackBlock1 B;
        }

        /// <summary>
        /// 4 bytes of storage
        /// </summary>
        public struct StackBlock4
        {
            public StackBlock2 Lo;

            public StackBlock2 Hi;
        }

        /// <summary>
        /// 5 bytes of storage
        /// </summary>
        public struct StackBlock5
        {
            public StackBlock4 A;

            public StackBlock1 B;
        }

        /// <summary>
        /// 6 bytes of storage
        /// </summary>
        public struct StackBlock6
        {
            public StackBlock5 A;

            public StackBlock1 B;
        }

        /// <summary>
        /// 7 bytes of storage
        /// </summary>
        public struct StackBlock7
        {
            public StackBlock6 A;

            public StackBlock1 B;
        }

        /// <summary>
        /// 8 bytes of storage
        /// </summary>
        public struct StackBlock8
        {
            public StackBlock4 Lo;

            public StackBlock4 Hi;
        }

        /// <summary>
        /// 9 bytes of storage
        /// </summary>
        public struct StackBlock9
        {
            public StackBlock8 Lo;

            public StackBlock1 Hi;
        }

        /// <summary>
        /// 10 bytes of storage
        /// </summary>
        public struct StackBlock10
        {
            public StackBlock8 A;

            public StackBlock2 B;
        }

        /// <summary>
        /// 11 bytes of storage
        /// </summary>
        public struct StackBlock11
        {
            public StackBlock10 A;

            public StackBlock1 B;
        }

        /// <summary>
        /// 12 bytes of storage
        /// </summary>
        public struct StackBlock12
        {
            public StackBlock8 A;

            public StackBlock4 B;
        }

        /// <summary>
        /// 13 bytes of storage
        /// </summary>
        public struct StackBlock13
        {
            public StackBlock12 A;

            public StackBlock1 B;
        }

        /// <summary>
        /// 14 bytes of storage
        /// </summary>
        public struct StackBlock14
        {
            public StackBlock7 Lo;

            public StackBlock7 Hi;
        }

        /// <summary>
        /// 15 bytes of storage
        /// </summary>
        public struct StackBlock15
        {
            public StackBlock10 A;

            public StackBlock5 B;
        }

        /// <summary>
        /// 16 bytes of storage
        /// </summary>
        public struct StackBlock16
        {
            public StackBlock8 Lo;

            public StackBlock8 Hi;
        }

        /// <summary>
        /// 32 bytes of storage
        /// </summary>
        public struct StackBlock32
        {
            public StackBlock16 Lo;

            public StackBlock16 Hi;
        }

        /// <summary>
        /// 64 bytes of storage
        /// </summary>
        public struct StackBlock64
        {
            public StackBlock32 Lo;

            public StackBlock32 Hi;
        }

        /// <summary>
        /// 128 bytes of storage
        /// </summary>
        public struct StackBlock128
        {
            public StackBlock64 Lo;

            public StackBlock64 Hi;
        }

        /// <summary>
        /// 256 bytes of storage
        /// </summary>
        public struct StackBlock256
        {
            public StackBlock128 Lo;

            public StackBlock128 Hi;
        }
    }
}