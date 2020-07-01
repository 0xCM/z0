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

    public readonly struct ConversionMetrics
    {
        readonly Vector256<uint> Storage;

        [MethodImpl(Inline)]
        public static ConversionMetrics<S,T> define<S,T>(uint srcCount)
            where S : struct
            where T : struct
                => new ConversionMetrics<S,T>(srcCount);        
                
        [MethodImpl(Inline)]        
        public ConversionMetrics(uint SrcCount, uint SrcCellSize, uint DstCellSize, uint SrcSize, uint DstCount, uint DstSize)                
            => Storage = Vector256.Create(SrcCount, SrcCellSize, DstCellSize, SrcSize, DstCount, DstSize,0,0);

        public uint SrcCount 
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(0);
        }

        public uint SrcCellSize 
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(1);
        }

        public uint DstCellSize
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(2);
        }

        public uint SrcSize
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(3);
        }

        public uint DstCount
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(4);
        }

        public uint DstSize
        {
            [MethodImpl(Inline)]
            get => Storage.GetElement(5);
        }
    }    
}