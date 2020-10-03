//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct BitBlock8
    {
        public const int Size = 1;            

        public byte X0;
    }

    public struct BitBlock16
    {
        public const int Size = 2;            

        public ushort X0;
    }

    public struct BitBlock32
    {
        public const int Size = 4;            

        public uint X0;
    }

    public struct BitBlock64
    {
        public const int Size = 8;            

        public ulong X0;
    }

    /// <summary>
    /// Defines 16 bytes = 512 bits of stack-allocated storage
    /// </summary>
    public struct BitBlock128
    {
        public const int Size = 16;

        public ulong X0;

        public ulong X1;                                              
    }

    /// <summary>
    /// Covers 32 bytes = 256 bits of stack-allocated storage
    /// </summary>
    public struct BitBlock256
    {
        public const int Size = 32;

        public BitBlock128 X0;

        BitBlock128 X1;
    }

    /// <summary>
    /// Covers 64 bytes = 512 bits of stack-allocated storage
    /// </summary>
    public struct BitBlock512
    {
        public const int Size = 64; 

        public BitBlock256 X0;

        BitBlock256 X1;
    }

    /// <summary>
    /// Covers 128 bytes = 1024 bits of stack-allocated storage
    /// </summary>
    public struct BitStack1024
    {
        public const int Size = 128;            

        public BitBlock512 X0;

        BitBlock512 X1;
    }
}