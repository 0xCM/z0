//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemoryAddress : 
        IAddressable, 
        INullaryKnown, 
        IIdentification<MemoryAddress>, 
        INullary<MemoryAddress>
    {
        
        
        public readonly ulong Location;

        public static MemoryAddress Empty => new MemoryAddress(0);
 
        public bool IsEmpty { [MethodImpl(Inline)] get => Location == 0; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Location != 0; }

        public MemoryAddress Zero => Empty;

        public string IdentityText =>  Location.ToString("x") + HexSpecs.PostSpec;

        MemoryAddress IAddressable.Address 
        {
            [MethodImpl(Inline)]
            get => this;
        }

        [MethodImpl(Inline)]
        public static MemoryAddress Define(long location)
            => new MemoryAddress((ulong)location);

        [MethodImpl(Inline)]
        public static MemoryAddress Define(ulong location)
            => new MemoryAddress(location);

        [MethodImpl(Inline)]
        public static MemoryAddress Define(IntPtr location)
            => new MemoryAddress((ulong)location.ToInt64());

        /// <summary>
        /// Computes the bit-width of the smallest numeric type that can represent the address
        /// </summary>
        public NumericWidth MinWidth
        {
            [MethodImpl(Inline)]
            get
            {
                if(Location <= byte.MaxValue)
                    return NumericWidth.W8;
                else if(Location <= ushort.MaxValue)
                    return NumericWidth.W16;
                else if(Location <= uint.MaxValue)
                    return NumericWidth.W32;
                else
                    return NumericWidth.W64;
            }
        }

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(ulong src)
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator long(MemoryAddress src)
            => (long)src.Location;

        [MethodImpl(Inline)]
        public static implicit operator ulong(MemoryAddress src)
            => src.Location;

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(long src)
            => Define(src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(int src)
            => Define(src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(ushort src)
            => Define(src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(IntPtr src)
            => Define((ulong)src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(short src)
            => Define(src);

        [MethodImpl(Inline)]
        public static explicit operator ushort(MemoryAddress src)
            => (ushort)src.Location;

        [MethodImpl(Inline)]
        public static explicit operator uint(MemoryAddress src)
            => (uint)src.Location;

        [MethodImpl(Inline)]
        public static bool operator==(MemoryAddress a, MemoryAddress b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(MemoryAddress a, MemoryAddress b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator<(MemoryAddress a, MemoryAddress b)
            => a.Location < b.Location;

        [MethodImpl(Inline)]
        public static bool operator>(MemoryAddress a, MemoryAddress b)
            => a.Location > b.Location;

        [MethodImpl(Inline)]
        public static bool operator<=(MemoryAddress a, MemoryAddress b)
            => a.Location <= b.Location;

        [MethodImpl(Inline)]
        public static bool operator>=(MemoryAddress a, MemoryAddress b)
            => a.Location >= b.Location;

        [MethodImpl(Inline)]
        public static MemoryAddress operator+(MemoryAddress a, MemoryAddress b)
            => new MemoryAddress(a.Location + b.Location);

        [MethodImpl(Inline)]
        public static MemoryAddress operator-(MemoryAddress a, MemoryAddress b)
            => new MemoryAddress(a.Location - b.Location);

        [MethodImpl(Inline)]
        MemoryAddress(ulong absolute)
            => Location = absolute;

        public string Format()
            => IdentityText;        

        public string Format(NumericWidth width)
        {
            return width switch{
                    NumericWidth.W8 => ((byte)Location).FormatAsmHex(),
                    NumericWidth.W16 => ((ushort)Location).FormatAsmHex(),
                    NumericWidth.W32 => ((uint)Location).FormatAsmHex(),
                    _ => Location.FormatAsmHex(),
            };                        
        }

        public string FormatMinimal()
            => Format(MinWidth);

        public string Format(HexFormatConfig config)
            => Location.FormatHex(config);

        [MethodImpl(Inline)]
        public int CompareTo(MemoryAddress other)
            => this == other ? 0 : this < other ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(MemoryAddress src)
            => Location == src.Location;

        public override int GetHashCode()
            => Location.GetHashCode();

        public override bool Equals(object obj)
            => obj is MemoryAddress a && Equals(a);                    

        public override string ToString() 
            => Format();

        [MethodImpl(Inline)]
        public unsafe T* ToPointer<T>()
            where T : unmanaged
                => (T*)Location;
    }
}