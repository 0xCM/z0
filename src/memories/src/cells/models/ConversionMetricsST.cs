//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

   public readonly struct ConversionMetrics<S,T>
        where S : struct
        where T : struct
    {
        public readonly uint SrcCount;
        
        [MethodImpl(Inline)]
        public ConversionMetrics(uint srcCount)
            => SrcCount = srcCount;

        [MethodImpl(Inline)]
        public static implicit operator ConversionMetrics(ConversionMetrics<S,T> src)
            => src.Untyped;
        
        public uint SrcCellSize 
        {
            [MethodImpl(Inline)]
            get => (uint)Unsafe.SizeOf<S>();
        }

        public uint DstCellSize 
        {
            [MethodImpl(Inline)]
            get => (uint)Unsafe.SizeOf<T>();
        }

        public uint SrcSize
        {
            [MethodImpl(Inline)]
            get => SrcCount * SrcCellSize;
        }

        public uint DstCount
        {
            [MethodImpl(Inline)]
            get => SrcSize / DstCellSize;
        }

        public uint DstSize
        {
            [MethodImpl(Inline)]
            get => DstCount * DstCellSize;
        }

        public ConversionMetrics Untyped
        {
            [MethodImpl(Inline)]
            get => new ConversionMetrics(
                SrcCount: SrcCount, 
                SrcCellSize: SrcCellSize, 
                DstCellSize: DstCellSize, 
                SrcSize: SrcSize, 
                DstCount: DstCount,
                DstSize: DstSize
                );
        }
    }
}