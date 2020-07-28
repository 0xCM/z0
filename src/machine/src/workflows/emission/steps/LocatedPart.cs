//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct LocatedPart
    {
        public readonly IPart Part;

        public readonly FilePath ImagePath;

        public readonly MemoryAddress StartAddress;

        public readonly MemoryAddress EndAddress;

        public LocatedPart(IPart part, MemoryAddress @base, MemoryAddress last)
        {
            Part = part;
            ImagePath = FilePath.Define(part.Owner.Location);
            StartAddress = @base;
            EndAddress = last;
        }
        
        public PartId Id
        {
            [MethodImpl(Inline)]
            get => Part.Id;
        }
        
        public MemoryRange Segment
        {
            [MethodImpl(Inline)]
            get =>  (StartAddress, EndAddress);
        }
        
        public int CompareTo(LocatedPart src)
            => StartAddress.CompareTo(src.StartAddress);

        public int CompareTo(LocatedDependency src)
            => StartAddress.CompareTo(src.StartAddress);            
    }
}