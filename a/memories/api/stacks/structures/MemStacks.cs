//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    partial class Stacked
    {
        public ref struct MemStack8
        {
            public const int Size = 1;            

            internal byte X0;
        }

        public ref struct MemStack16
        {
            public const int Size = 2;            

            public ushort X0;
        }

        public ref struct MemStack32
        {
            public const int Size = 4;            

            public uint X0;
        }

        public ref struct MemStack64
        {
            public const int Size = 8;            

            public ulong X0;
        }

        /// <summary>
        /// Defines 16 bytes = 512 bits of stack-allocated storage
        /// </summary>
        public ref struct MemStack128
        {
            public const int Size = 16;

            public ulong X0;

            public ulong X1;      
                                        
        }

        /// <summary>
        /// Covers 32 bytes = 256 bits of stack-allocated storage
        /// </summary>
        public ref struct MemStack256
        {
            public const int Size = 32;

            public MemStack128 X0;

            MemStack128 X1;
        }

        /// <summary>
        /// Covers 64 bytes = 512 bits of stack-allocated storage
        /// </summary>
        public ref struct MemStack512
        {
            public const int Size = 64; 

            public MemStack256 X0;

            MemStack256 X1;
        }

        /// <summary>
        /// Covers 128 bytes = 1024 bits of stack-allocated storage
        /// </summary>
        public ref struct MemStack1024
        {
            public const int Size = 128;            

            public MemStack512 X0;

            MemStack512 X1;
        }
    }
}