//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static partial class Stacked
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

        public ref struct CharStack2
        {
            public char C0;

            char C1;
        }

        public ref struct CharStack4
        {
            public CharStack2 C0;

            CharStack2 C1;
        }

        public ref struct CharStack8
        {
            public CharStack4 C0;

            CharStack4 C1;
        }

        public ref struct CharStack16
        {
            public CharStack8 C0;

            CharStack8 C1;        
        }

        public ref struct CharStack32
        {
            public CharStack16 C0;

            CharStack16 C1;        
        }

        public ref struct CharStack64
        {
            public CharStack32 C0;

            CharStack32 C1;       
        }        
    }
}