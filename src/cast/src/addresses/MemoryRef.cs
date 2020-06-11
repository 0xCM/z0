//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Konst;

    public readonly struct MemoryRef : IAddressable<MemoryRef>, ITextual, IEquatable<MemoryRef>
    {
        readonly Vector128<ulong> Data;        

        [MethodImpl(Inline)]
        public static MemoryRef define(MemoryAddress address, ByteSize size)
            => new MemoryRef(address,size);
        
        [MethodImpl(Inline)]
        public static unsafe Span<byte> read(MemoryRef src)
        {
            var reader = PointedReader.Create(src.Address.ToPointer<byte>(), src.Length);
            Span<byte> dstA = new byte[src.Length];            
            var count = reader.ReadAll(dstA);
            return dstA;
        }

        [MethodImpl(Inline)]
        public static unsafe int read(MemoryRef src, Span<byte> dst)
        {
            var reader = PointedReader.Create(src.Address.ToPointer<byte>(), src.Length);
            return reader.ReadAll(dst);            
        }

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan<byte> cover(MemoryRef src)
            => Addresses.cover(src.Address, src.Length);        

        [MethodImpl(Inline)]
        public unsafe static MemoryRef From(ReadOnlySpan<byte> src)
            => new MemoryRef(Control.gptr(Control.head(src)), src.Length);

        public static MemoryRef Empty => new MemoryRef(default(Vector128<ulong>));
                
        ulong Lo
        {
            [MethodImpl(Inline)]
            get => Data.GetElement(0);
        }

        ulong Hi
        {
            [MethodImpl(Inline)]
            get => Data.GetElement(1);
        }

        public MemoryAddress Address 
        {
            [MethodImpl(Inline)]
            get => Lo;
        }
        public ByteSize Length 
        {
            [MethodImpl(Inline)]
            get => (uint)Hi;
        }

        [MethodImpl(Inline)]
        internal MemoryRef(Vector128<ulong> src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public unsafe MemoryRef(byte* src, int length)
        {
            Data = Vector128.Create((ulong)src, (ulong)length);
        }

        [MethodImpl(Inline)]
        public MemoryRef(MemoryAddress src, int length)
        {
            Data = Vector128.Create((ulong)src, (ulong)length);
        }  

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.Equals(default);
        }      
        
        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Data.Equals(default);
        }      

        public MemoryRef Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Address.Format();
        
        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Load()
            => Addresses.cover(Address, Length);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Load<T>()
            => Addresses.cover<T>(Address, Length);
       
        [MethodImpl(Inline)]
        public uint Hash()
            => Control.hash(Lo, Hi);
        
        [MethodImpl(Inline)]
        public bool Equals(MemoryRef src)
            => src.Data.Equals(Data);
        
        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash();
    }
}