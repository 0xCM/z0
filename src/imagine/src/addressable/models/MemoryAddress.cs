//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public unsafe readonly struct MemoryAddress : IAddress<MemoryAddress,W64,ulong>, IAddressable64
    {
        [MethodImpl(Inline)]
        public static MemoryAddress from(Ref src)
            => new MemoryAddress(src.Location);
        
        public ulong Location {get;}

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
        public static implicit operator MemoryAddress(void* pSrc)
            => new MemoryAddress(pSrc);

        [MethodImpl(Inline)]
        public static explicit operator char*(MemoryAddress src)
            => (char*)src.Location;

        [MethodImpl(Inline)]
        public static explicit operator byte*(MemoryAddress src)
            => (byte*)src.Location;

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(IntPtr src)            
            => new MemoryAddress((ulong)src.ToInt64());

        [MethodImpl(Inline)]
        public static implicit operator IntPtr(MemoryAddress src)
            => (IntPtr)src.Location;

        [MethodImpl(Inline)]
        public static implicit operator long(MemoryAddress src)
            => (long)src.Location;

        [MethodImpl(Inline)]
        public static implicit operator ulong(MemoryAddress src)
            => src.Location;

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(ulong src)
            => new MemoryAddress(src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(long src)
            => new MemoryAddress((ulong)src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(int src)
            => new MemoryAddress((uint)src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(ushort src)
            => new MemoryAddress(src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(short src)
            => new MemoryAddress((ushort)src);

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
        public MemoryAddress(ulong absolute)
            => Location = absolute;

        [MethodImpl(Inline)]
        public MemoryAddress(void* pSrc)
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
        public int CompareTo(MemoryAddress src)
            => Location == src.Location ? 0 : Location < src.Location ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(MemoryAddress src)
            => Location == src.Location;
        
        public uint Hash
        {
            [MethodImpl(Inline)]
            get => core.hash(Location);
        }

        public override int GetHashCode()
            => (int)Hash;

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