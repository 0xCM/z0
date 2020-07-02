//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;
    
    public unsafe readonly struct MemoryAddress : IAddress<MemoryAddress,W64,ulong>, IAddressable64
    {
        public ulong Location {get;}

        [MethodImpl(Inline)]
        public static unsafe MemoryAddress from<T>(in T src)
            => pvoid<T>(src);        

        /// <summary>
        /// Defines an address predicated on the leading source cell
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline)]
        public static unsafe MemoryAddress from<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => gptr(first(src));
                
        public bool IsEmpty 
        {
             [MethodImpl(Inline)] 
             get => Location == 0; 
        }   

        public bool IsNonEmpty 
        {
             [MethodImpl(Inline)] 
             get => Location != 0; 
        }

        public MemoryAddress Zero 
            => Empty;

        public string Identifier 
            => Location.ToString("x") + HexSpecs.PostSpec;

        MemoryAddress IAddressable64.Address 
        {
            [MethodImpl(Inline)]
            get => this;
        }

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
        public static implicit operator MemoryAddress(void* p)
            => Addressable.address(p);

        [MethodImpl(Inline)]
        public static explicit operator char*(MemoryAddress src)
            => (char*)src.Location;

        [MethodImpl(Inline)]
        public static explicit operator byte*(MemoryAddress src)
            => (byte*)src.Location;

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(IntPtr src)
            => Root.address(src);

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(MemoryAddress src)
            => (IntPtr)src.Location;

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(ulong src)
            => Addressable.address(src);

        [MethodImpl(Inline)]
        public static implicit operator long(MemoryAddress src)
            => (long)src.Location;

        [MethodImpl(Inline)]
        public static implicit operator ulong(MemoryAddress src)
            => src.Location;

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(long src)
            => Addressable.address((ulong)src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(int src)
            => Addressable.address((uint)src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(ushort src)
            => Addressable.address(src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(short src)
            => Addressable.address((ushort)src);

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
        internal MemoryAddress(ulong absolute)
            => Location = absolute;

        [MethodImpl(Inline)]
        internal MemoryAddress(void* pSrc)
            => Location = (ulong)pSrc;

        public string Format()
            => Identifier;        

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

        [MethodImpl(Inline)]
        public uint Hash()
            => Root.hash(Location);

        public override int GetHashCode()
            => (int)Hash();

        public override bool Equals(object obj)
            => obj is MemoryAddress a && Equals(a);                    

        public override string ToString() 
            => Format();

        [MethodImpl(Inline)]
        public unsafe ref T Ref<T>()
            => ref Unsafe.AsRef<T>((void*)Location);
        
        [MethodImpl(Inline)]
        public unsafe T* Pointer<T>()
            where T : unmanaged
                => (T*)Location;

        public static MemoryAddress Empty 
            => new MemoryAddress(0); 
    }
}