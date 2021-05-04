//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;


    using static Part;
    using static memory;


    public readonly struct Bins
    {

        [MethodImpl(Inline), Op]
        public static MemoryBin define(uint key, Address32 min, Address32 max)
            => new MemoryBin(key,min,max);




    }

    public struct Bin<I,T>
        where I : unmanaged, IComparable<I>
        where T : IComparable<T>
    {

    }

    public readonly struct MemoryBins
    {
        readonly Index<MemoryBin> Data;

        [MethodImpl(Inline)]
        public MemoryBins(MemoryBin[] src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator MemoryBins(MemoryBin[] src)
            => new MemoryBins(src);


        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public void Resequence()
        {
            Data.Sort();
            ref var bins = ref Data.First;
            for(var i=0u; i<Count; i++)
            {
                ref var bin = ref seek(bins,i);
                bin.Sequence = i;
            }
        }
    }

    public struct MemoryBin
    {
        public uint Sequence {get; set;}

        public Address32 Min {get;}

        public Address32 Max {get;}

        [MethodImpl(Inline)]
        public MemoryBin(uint seq, Address32 min, Address32 max)
        {
            Sequence = seq;
            Min = min;
            Max = max;
        }


        [MethodImpl(Inline)]
        public int CompareTo(MemoryBin src)
            => Min.CompareTo(src.Min);

        [MethodImpl(Inline)]
        public bool Contains(MemoryAddress src)
            => src >= Min && src <= Max;
    }
}