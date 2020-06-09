//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    
    static class MUtil
    {
        [MethodImpl(Inline)]
        static unsafe void* pvoid<T>(ref T src)
            => Unsafe.AsPointer(ref src); 

        [MethodImpl(Inline)]
        static unsafe T* ptr<T>(ref T src)
            where T : unmanaged
                => (T*)pvoid(ref src);

        [MethodImpl(Inline)]
        static unsafe T* cptr<T>(in T src)
            where T : unmanaged
                => ptr(ref Control.edit(in src));

        /// <summary>
        /// Presents a readonly reference as a generic pointer which should intself be considered constant
        /// but, as far as the author is aware, no facility within the language can encode that constraint
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* constptr<T>(in T src)
            where T : unmanaged
                => cptr(in src);

    }
    
    [ApiHost]
    public readonly struct MemoryAddress : 
        IAddress<MemoryAddress,W64,ulong>, 
        IAddressable, 
        IIdentification<MemoryAddress>
    {
        public ulong Location {get;}
        
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ref T toRef<T>(MemoryAddress src)
            => ref src.ToRef<T>();
         
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe MemoryAddress from<T>(in T src)
            where T : unmanaged
                => Control.gptr<T>(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> edit<T>(MemoryAddress src, int length)
            => MemoryMarshal.CreateSpan(ref src.ToRef<T>(), length);

        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> edit(MemoryAddress src, int length)
            => MemoryMarshal.CreateSpan(ref src.ToRef<byte>(), length);

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> cover(MemoryAddress src, int length)
            => MemoryMarshal.CreateReadOnlySpan(ref src.ToRef<byte>(), length);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ReadOnlySpan<T> cover<T>(MemoryAddress src, int length)
            => MemoryMarshal.CreateReadOnlySpan(ref src.ToRef<T>(), length);

        [MethodImpl(Inline), Op]
        public static MemoryAddress define(long location)
            => new MemoryAddress((ulong)location);

        [MethodImpl(Inline), Op]
        public static MemoryAddress define(ulong location)
            => new MemoryAddress(location);

        [MethodImpl(Inline), Op]
        public static MemoryAddress define(IntPtr location)
            => new MemoryAddress((ulong)location.ToInt64());
        
        [MethodImpl(Inline)]
        public unsafe static implicit operator MemoryAddress(void* p)
            => define((ulong)p);
        
        public static MemoryAddress Empty => new MemoryAddress(0);
 
        public bool IsEmpty { [MethodImpl(Inline)] get => Location == 0; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Location != 0; }

        public MemoryAddress Zero 
            => Empty;

        public string IdentityText 
            => Location.ToString("x") + HexSpecs.PostSpec;

        MemoryAddress IAddressable.Address 
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
        public static implicit operator MemoryAddress(ulong src)
            => define(src);

        [MethodImpl(Inline)]
        public static implicit operator long(MemoryAddress src)
            => (long)src.Location;

        [MethodImpl(Inline)]
        public static implicit operator ulong(MemoryAddress src)
            => src.Location;

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(long src)
            => define(src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(int src)
            => define(src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(ushort src)
            => define(src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(IntPtr src)
            => define((ulong)src);

        [MethodImpl(Inline)]
        public static explicit operator MemoryAddress(short src)
            => define(src);

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

        [MethodImpl(Inline)]
        public uint Hash()
            => Control.hash(Location);

        public override int GetHashCode()
            => (int)Hash();

        public override bool Equals(object obj)
            => obj is MemoryAddress a && Equals(a);                    

        public override string ToString() 
            => Format();

        [MethodImpl(Inline)]
        public unsafe ref T ToRef<T>()
            => ref Unsafe.AsRef<T>((void*)Location);
        
        [MethodImpl(Inline)]
        public unsafe T* ToPointer<T>()
            where T : unmanaged
                => (T*)Location;
    }
}