//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemoryOffset : IAddressable<MemoryOffset>
    {
        public static MemoryOffset Empty 
            => new MemoryOffset(MemoryAddress.Empty, 0, NumericWidth.None);

        public MemoryAddress Base {get;}

        public ulong Offset {get;}

        public NumericWidth OffsetWidth {get;}

        /// <summary>
        /// The offset magnitude presented as an address
        /// </summary>
        public MemoryAddress OffsetAddress
        {
            [MethodImpl(Inline)] 
            get => Offset;
        }

        /// <summary>
        /// The absolute address
        /// </summary>
        public MemoryAddress Absolute
        {
            [MethodImpl(Inline)] 
            get => IsEmpty ? MemoryAddress.Empty : (Base + Offset);
        }

        MemoryAddress IAddressable.Address 
            => IsEmpty ? MemoryAddress.Empty : (Base + Offset);

        public MemoryOffset Zero  
        { 
            [MethodImpl(Inline)] 
            get => Empty; 
        }

        public bool IsEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Base.Location == 0 && Offset == 0;
        }

        public bool IsNonEmpty  
        { 
            [MethodImpl(Inline)] 
            get => !IsNonEmpty; 
        }

        [MethodImpl(Inline)]
        public static bool operator==(MemoryOffset a, MemoryOffset b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(MemoryOffset a, MemoryOffset b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        internal MemoryOffset(MemoryAddress @base, ulong offset, NumericWidth width)
        {
            Base = @base;
            Offset = offset;
            OffsetWidth = width;
        }
        
        public string Format(char delimiter)
        {
            MemoryAddress offset = Offset;            
            return string.Concat(Base.Format(), delimiter, offset.Format(OffsetWidth));
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