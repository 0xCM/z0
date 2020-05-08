//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemoryOffset : 
        IAddressable, 
        INullaryKnown, 
        INullary<MemoryOffset>
    {
        public MemoryAddress Base {get;}

        public ulong Offset {get;}

        public NumericWidth OffsetWidth {get;}

        public static MemoryOffset Empty  => new MemoryOffset(0, 0, 0);

        MemoryAddress IAddressable.Address => Base;

        public MemoryOffset Zero  { [MethodImpl(Inline)] get => Empty; }

        public bool IsEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Base == 0 && Offset == 0 && OffsetWidth == 0;
        }

        public bool IsNonEmpty  { [MethodImpl(Inline)] get => !IsNonEmpty; }

        [MethodImpl(Inline)]
        public static MemoryOffset Define(MemoryAddress @base, byte offset)
            => new MemoryOffset(@base, offset, NumericWidth.W8);

        [MethodImpl(Inline)]
        public static MemoryOffset Define(MemoryAddress @base, ushort offset)
            => new MemoryOffset(@base, offset, NumericWidth.W16);

        [MethodImpl(Inline)]
        public static MemoryOffset Define(MemoryAddress @base, uint offset)
            => new MemoryOffset(@base, offset, NumericWidth.W32);

        [MethodImpl(Inline)]
        public static MemoryOffset Define(MemoryAddress @base, ulong offset)
            => new MemoryOffset(@base, offset, NumericWidth.W64);

        [MethodImpl(Inline)]
        public static MemoryOffset Derive(MemoryAddress @base, MemoryAddress relative)
        {
            var offset = @base.Location - relative.Location;
            if(offset <= byte.MaxValue)
                return Define(@base, (byte)offset);
            else if(offset <= ushort.MaxValue)
                return Define(@base, (ushort)offset);
            else if(offset <= uint.MaxValue)
                return Define(@base, (uint)offset);
            else
                return Define(@base, offset);
        }

        [MethodImpl(Inline)]
        public static bool operator==(MemoryOffset a, MemoryOffset b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(MemoryOffset a, MemoryOffset b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        MemoryOffset(MemoryAddress @base, ulong offset, NumericWidth width)
        {
            Base = @base;
            Offset = offset;
            OffsetWidth = width;
        }
        
        public string Format(char delimiter)
        {
            var offset = OffsetWidth switch{
                    NumericWidth.W8 => ((byte)Offset).FormatAsmHex(),
                    NumericWidth.W16 => ((ushort)Offset).FormatAsmHex(),
                    NumericWidth.W32 => ((uint)Offset).FormatAsmHex(),
                    _ => Offset.FormatAsmHex(),
            };
            
            return string.Concat(Base.Format(), delimiter, offset);
        }

        [MethodImpl(Inline)]
        public MemoryOffset AccrueOffset(ulong dx)
            => new MemoryOffset(Base, Offset + dx, OffsetWidth);

        public string Format()
            => Format(Chars.Space);

        [MethodImpl(Inline)]
        public int CompareTo(MemoryOffset src)
            => Base == src.Base ? (Offset.CompareTo(src.Offset)) : Base.CompareTo(src.Base);

        [MethodImpl(Inline)]
        public bool Equals(MemoryOffset src)
            => Base == src.Base && Offset == src.Offset;

        public override int GetHashCode()
            => HashCode.Combine(Base,Offset);

        public override bool Equals(object obj)
            => obj is MemoryOffset a && Equals(a);                    

        public override string ToString() 
            => Format();
    }
}