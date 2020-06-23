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

    public readonly struct TargetCount
    {
        readonly Vector256<int> Storage;

        [MethodImpl(Inline)]
        public TargetCount(int SrcCount, int SrcCellSize, int DstCellSize, int SrcSize, int DstCount, int DstSize)                
            => Storage = Vector256.Create(SrcCount, SrcCellSize, DstCellSize, SrcSize, DstCount, DstSize,0,0);

        [MethodImpl(Inline)]
        public static TargetCount<S,T> define<S,T>(int srcCount)
            where S : struct
            where T : struct
                => new TargetCount<S,T>(srcCount);        
        public int SrcCount 
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(0);
        }

        public int SrcCellSize 
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(1);
        }

        public int DstCellSize
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(2);
        }

        public int SrcSize
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(3);
        }

        public int DstCount
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(4);
        }

        public int DstSize
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(5);
        }
    }
    
    public readonly struct TargetCount<S,T>
        where S : struct
        where T : struct
    {
        public readonly int SrcCount;
        
        [MethodImpl(Inline)]
        public TargetCount(int srcCount)
            => SrcCount = srcCount;

        [MethodImpl(Inline)]
        public static implicit operator TargetCount(TargetCount<S,T> src)
            => src.Untyped;
        
        public int SrcCellSize 
        {
            [MethodImpl(Inline)]
            get => As.size<S>();
        }

        public int DstCellSize 
        {
            [MethodImpl(Inline)]
            get => As.size<T>();
        }

        public int SrcSize
        {
            [MethodImpl(Inline)]
            get => SrcCount * SrcCellSize;
        }

        public int DstCount
        {
            [MethodImpl(Inline)]
            get => SrcSize / DstCellSize;
        }

        public int DstSize
        {
            [MethodImpl(Inline)]
            get => DstCount * DstCellSize;
        }

        public TargetCount Untyped
        {
            [MethodImpl(Inline)]
            get => new TargetCount(
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