//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LocatedDependency
    {
        public readonly FilePath ImagePath;

        public readonly MemoryAddress StartAddress;

        public readonly MemoryAddress EndAddress;

        public LocatedDependency(FilePath path, MemoryAddress start, MemoryAddress end)
        {
            ImagePath = path;
            StartAddress = start;
            EndAddress = end;
        }
        
        public MemoryRange Segment
        {
            [MethodImpl(Inline)]
            get => (StartAddress, EndAddress);
        }

        public int CompareTo(LocatedPart src)
            => StartAddress.CompareTo(src.StartAddress);

        public int CompareTo(LocatedDependency src)
            => StartAddress.CompareTo(src.StartAddress);
    }
}