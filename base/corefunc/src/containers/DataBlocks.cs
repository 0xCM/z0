//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;


    public static class DataBlocks
    {
        [MethodImpl(Inline)]
        public static Block128 alloc(N128 n)
            => default;

        [MethodImpl(Inline)]
        public static Block256 alloc(N256 n)
            => default;

        [MethodImpl(Inline)]
        public static Block512 alloc(N512 n)
            => default;

        [MethodImpl(Inline)]
        public static Block1024 alloc(N1024 n)
            => default;

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Block128 src)
            => new Span<ulong>(refptr(ref src.X0), 2).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Block256 src)
            => new Span<ulong>(refptr(ref src.X0), 4).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Block512 src)
            => new Span<ulong>(refptr(ref src.X0), 8).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Block1024 src)
            => new Span<ulong>(refptr(ref src.X0), 16).AsBytes();

        [MethodImpl(Inline)]
        public static void store(in byte src, uint count, ref Block128 dst)
        {
            ref var dstBytes = ref uint8(ref dst.X0);
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref asRef(in src), count);
        }
    }

    public static class DataBlockX
    {

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Block128 src)
            => DataBlocks.bytes(ref src);

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Block256 src)
            => DataBlocks.bytes(ref src);

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Block512 src)
            => DataBlocks.bytes(ref src);

        [MethodImpl(Inline)]
        public static Span<byte> AsBytes(this ref Block1024 src)
            => DataBlocks.bytes(ref src);

        [MethodImpl(Inline)]
        public static BitString ToBitString(this Block128 src)
            => src.X1.ToBitString().Concat(src.X0.ToBitString());
    }


    public ref struct Block128
    {
        public ulong X0;

        public ulong X1;        
    }

    public ref struct Block256
    {
        public ulong X0;

        public ulong X1;
        
        public ulong X2;

        public ulong X3;
    }

    public ref struct Block512
    {
        public ulong X0;

        public ulong X1;
        
        public ulong X2;

        public ulong X3;

        public ulong X4;

        public ulong X5;
        
        public ulong X6;

        public ulong X7;
    }

    public ref struct Block1024
    {
        public ulong X0;

        public ulong X1;
        
        public ulong X2;

        public ulong X3;

        public ulong X4;

        public ulong X5;
        
        public ulong X6;

        public ulong X7;

        public ulong X8;

        public ulong X9;
        
        public ulong XA;

        public ulong XB;

        public ulong XC;

        public ulong XD;
        
        public ulong XE;

        public ulong XF;
    }


}