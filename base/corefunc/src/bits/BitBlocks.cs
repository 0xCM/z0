//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static AsIn;
    using static As;

    using static zfunc;
    using static BitBlocks;

    public interface IBitBlock
    {
        Span<byte> Bits {get;}
    }

    public struct BitBlock<N,T> : IBitBlock
        where N : unmanaged, ITypeNat
        where T : unmanaged, IBitBlock
    {
        T data;

        [MethodImpl(Inline)]
        internal BitBlock(T data)
        {
            this.data = data;
        }

        public Span<byte> Bits
        {
            [MethodImpl(Inline)]
            get => BitView.Over(ref data).Bytes;
        }
    }
    
    public static class BitBlock
    {
        public static BitBlock<N8,BitBlock8> alloc(N8 width)
            => new BitBlock<N8, BitBlock8>(default);

        public static BitBlock<N16,BitBlock16> alloc(N16 width)
            => new BitBlock<N16, BitBlock16>(default);

        public static BitBlock<N32,BitBlock32> alloc(N32 width)
            => new BitBlock<N32, BitBlock32>(default);

        public static BitBlock<N64,BitBlock64> alloc(N64 width)
            => new BitBlock<N64, BitBlock64>(default);

        public static BitBlock<N128,BitBlock128> alloc(N128 width)
            => new BitBlock<N128, BitBlock128>(default);

        public static BitBlock<N256,BitBlock256> alloc(N256 width)
            => new BitBlock<N256, BitBlock256>(default);

        public static BitBlock<N512,BitBlock512> alloc(N512 width)
            => new BitBlock<N512, BitBlock512>(default);

    }

    public static class BitBlocks
    {
        public struct BitBlock8 : IBitBlock
        {

            byte data;

            public const int BitCount = 8;


            [MethodImpl(Inline)]
            public BitBlock8(byte data)
            {
                this.data  = data;
            }

            public Span<byte> Bits
            {
                [MethodImpl(Inline)]
                get => BitView.Over(ref data).Bytes;
            }

        }

        public struct BitBlock16 : IBitBlock
        {

            ushort data;

            public const int BitCount = 16;

            [MethodImpl(Inline)]
            public BitBlock16(ushort data)
            {
                this.data  = data;
            }

            public Span<byte> Bits
            {
                [MethodImpl(Inline)]
                get => BitView.Over(ref data).Bytes;
            }

        }

        public struct BitBlock32 : IBitBlock
        {
            uint data;


            public const int BitCount = 32;

            [MethodImpl(Inline)]
            public BitBlock32(uint data)
            {
                this.data  = data;                
            }

            public Span<byte> Bits
            {
                [MethodImpl(Inline)]
                get => BitView.Over(ref data).Bytes;
            }

        }

        public struct BitBlock64 : IBitBlock
        {
            public const int BitCount = 64;

            ulong data;

            [MethodImpl(Inline)]
            public BitBlock64(ulong data)
            {
                this.data  = data;
            }

            public Span<byte> Bits
            {
                [MethodImpl(Inline)]
                get => BitView.Over(ref data).Bytes;
            }

        }

        public struct BitBlock128 : IBitBlock
        {
            public const int BitCount = 128;

            Pair<ulong> data;

            [MethodImpl(Inline)]
            public BitBlock128(ulong x0, ulong x1)
            {
                data = (x0,x1);
            }

            public Span<byte> Bits
            {
                [MethodImpl(Inline)]
                get => BitView.Over(ref data).Bytes;
            }

        }

        public struct BitBlock256 : IBitBlock
        {

            Pair<BitBlock128> data;

            public const int BitCount = 256;

            [MethodImpl(Inline)]
            public BitBlock256(BitBlock128 x0, BitBlock128 x1)
            {
                data = (x0,x1);
            }

            public Span<byte> Bits
            {
                [MethodImpl(Inline)]
                get => BitView.Over(ref data).Bytes;
            }
        }

        public struct BitBlock512 : IBitBlock
        {
            Pair<BitBlock256> data;

            public const int BitCount = 512;


            [MethodImpl(Inline)]
            public BitBlock512(BitBlock256 x0, BitBlock256 x1)
            {
                data = (x0,x1);
            }

            public Span<byte> Bits
            {
                [MethodImpl(Inline)]
                get => BitView.Over(ref data).Bytes;
            }
        }

    }
}