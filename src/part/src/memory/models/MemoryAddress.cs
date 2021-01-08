//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public unsafe readonly struct MemoryAddress : IAddress<ulong>, IDataTypeComparable<MemoryAddress>
    {
        public ulong Location {get;}

        [MethodImpl(Inline)]
        public MemoryAddress(ulong absolute)
            => Location = absolute;

        [MethodImpl(Inline)]
        public MemoryAddress(void* pSrc)
            => Location = (ulong)pSrc;

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
            => Location.ToString("x") + HexFormatSpecs.PostSpec;

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

        public string Format()
            => Location.ToString("x") + HexFormatSpecs.PostSpec;

        public string Format(NumericWidth width)
        {
            return width switch{
                    NumericWidth.W8 => ((byte)Location).FormatAsmHex(2),
                    NumericWidth.W16 => ((ushort)Location).FormatAsmHex(4),
                    NumericWidth.W32 => ((uint)Location).FormatAsmHex(8),
                    _ => Location.FormatAsmHex(12),
            };
        }

        [MethodImpl(Inline)]
        public string FormatMinimal()
            => Format(MinWidth);

        [MethodImpl(Inline)]
        public string Format(byte pad)
            => Location.FormatAsmHex(pad);

        [MethodImpl(Inline)]
        public int CompareTo(MemoryAddress src)
            => Location == src.Location ? 0 : Location < src.Location ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(MemoryAddress src)
            => Location == src.Location;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => alg.hash.calc(Location);
        }

        [MethodImpl(Inline)]
        public unsafe ref T Ref<T>()
            => ref Unsafe.AsRef<T>((void*)Location);

        [MethodImpl(Inline)]
        public unsafe void* Pointer()
            => (void*)Location;

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object obj)
            => obj is MemoryAddress a && Equals(a);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public unsafe T* Pointer<T>()
            where T : unmanaged
                => (T*)Location;

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
        public static explicit operator void*(MemoryAddress src)
            => (void*)src.Location;

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
        public static MemoryAddress operator+(MemoryAddress a, byte* b)
            => new MemoryAddress(a.Location + (ulong)b);

        [MethodImpl(Inline)]
        public static MemoryAddress operator+(MemoryAddress a, ushort* b)
            => new MemoryAddress(a.Location + (ulong)b);

        [MethodImpl(Inline)]
        public static MemoryAddress operator+(MemoryAddress a, uint* b)
            => new MemoryAddress(a.Location + (ulong)b);

        [MethodImpl(Inline)]
        public static MemoryAddress operator+(MemoryAddress a, ulong* b)
            => new MemoryAddress(a.Location + (ulong)b);

        [MethodImpl(Inline)]
        public static MemoryAddress operator+(MemoryAddress a, void* b)
            => new MemoryAddress(a.Location + (ulong)b);

        [MethodImpl(Inline)]
        public static MemoryAddress operator+(MemoryAddress a, ByteSize b)
            => new MemoryAddress(a.Location + (ulong)b);

        [MethodImpl(Inline)]
        public static MemoryAddress operator+(MemoryAddress a, byte size)
            => new MemoryAddress(a.Location + size);

        [MethodImpl(Inline)]
        public static MemoryAddress operator+(MemoryAddress a, ushort size)
            => new MemoryAddress(a.Location + size);

        [MethodImpl(Inline)]
        public static MemoryAddress operator+(MemoryAddress a, uint size)
            => new MemoryAddress(a.Location + size);

        [MethodImpl(Inline)]
        public static MemoryAddress operator+(MemoryAddress a, ulong size)
            => new MemoryAddress(a.Location + size);

        [MethodImpl(Inline)]
        public static MemoryAddress operator-(MemoryAddress a, MemoryAddress b)
            => new MemoryAddress(a.Location - b.Location);

        public static MemoryAddress Empty
            => new MemoryAddress(0);
    }
}