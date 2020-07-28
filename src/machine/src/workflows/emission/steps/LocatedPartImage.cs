//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct LocatedPartImage
    {
        public readonly PartId Id;

        public readonly FilePath ImagePath;

        public readonly MemoryAddress BaseAddress;

        public readonly MemoryAddress EntryAddress;

        public readonly uint Size;

        [MethodImpl(Inline)]
        public LocatedPartImage(FilePath path, MemoryAddress @base, MemoryAddress entry, uint size)
        {
            Id = PartIdParser.single(path.FileName.Name.Replace("z0.", EmptyString).Replace(".dll", EmptyString).Replace(".exe", EmptyString));                
            ImagePath = path;
            BaseAddress = @base;
            EntryAddress = entry;
            Size = size;
        }

        public int CompareTo(LocatedPartImage src)
            => BaseAddress.CompareTo(src.BaseAddress);
    
        public bool Equals(LocatedPartImage src)
            => src.BaseAddress == BaseAddress;
        
        public override int GetHashCode()
            => BaseAddress.GetHashCode();

        public override bool Equals(object src)
            => src is LocatedPartImage x && Equals(x);
        
        public string Format()
        {
            var dst = text.build();
            dst.Append(Id.Format().PadRight(16));
            dst.Append(SpacePipe);
            dst.Append(BaseAddress.Format().PadRight(16));
            dst.Append(SpacePipe);
            dst.Append(Size.ToString("#,#").PadRight(10));
            dst.Append(SpacePipe);
            dst.Append(EntryAddress.Format().PadRight(16));
            return dst.ToString();
        }
    }
}