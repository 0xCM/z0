//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents an in-memory part with a specified base address
    /// </summary>
    public readonly struct LocatedPart
    {
        public IPart Part {get;}

        public FilePath ImagePath {get;}

        public MemoryAddress BaseAddress {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        public LocatedPart(IPart part, MemoryAddress @base, ByteSize size)
        {
            Part = part;
            ImagePath = FilePath.Define(part.Owner.Location);
            BaseAddress = @base;
            Size = size;
        }

        public PartId Id
        {
            [MethodImpl(Inline)]
            get => Part.Id;
        }

        public MemoryRange Range
        {
            [MethodImpl(Inline)]
            get =>  (BaseAddress, (BaseAddress + (uint)Size));
        }

        public int CompareTo(LocatedPart src)
            => BaseAddress.CompareTo(src.BaseAddress);


        public bool Equals(LocatedPart src)
            => src.BaseAddress == BaseAddress;

        public override int GetHashCode()
            => BaseAddress.GetHashCode();

        public override bool Equals(object src)
            => src is LocatedPart x && Equals(x);

        public string Format()
        {
            var dst = text.build();
            dst.Append(Id.Format().PadRight(16));
            dst.Append(SpacePipe);
            dst.Append(BaseAddress.Format().PadRight(16));
            dst.Append(SpacePipe);
            dst.Append(Size.Format("#,#").PadRight(10));
            dst.Append(SpacePipe);
            dst.Append(Range.End.Format().PadRight(16));
            return dst.ToString();
        }
    }
}