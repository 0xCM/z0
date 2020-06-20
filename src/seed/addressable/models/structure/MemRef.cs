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

    public readonly struct MemRef : IAddressable<MemRef>, ITextual, IEquatable<MemRef>
    {
        readonly Vector128<ulong> Data;        
        
        [MethodImpl(Inline)]
        public static unsafe Span<byte> read(MemRef src)
        {
            var reader = PointedReader.Create(src.Address.ToPointer<byte>(), src.Length);
            Span<byte> dstA = new byte[src.Length];            
            var count = reader.ReadAll(dstA);
            return dstA;
        }

        [MethodImpl(Inline)]
        public static unsafe int read(MemRef src, Span<byte> dst)
        {
            var reader = PointedReader.Create(src.Address.ToPointer<byte>(), src.Length);
            return reader.ReadAll(dst);            
        }

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan<byte> cover(MemRef src)
            => Addresses.cover(src.Address, src.Length);        

        [MethodImpl(Inline)]
        public unsafe static MemRef memref(ReadOnlySpan<byte> src)
            => new MemRef(Root.gptr(Root.head(src)), src.Length);
                
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
        internal MemRef(Vector128<ulong> src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public unsafe MemRef(byte* src, int length)
        {
            Data = Vector128.Create((ulong)src, (ulong)length);
        }

        [MethodImpl(Inline)]
        public MemRef(MemoryAddress src, int length)
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

        public MemRef Zero
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
            => Root.hash(Lo, Hi);
        
        [MethodImpl(Inline)]
        public bool Equals(MemRef src)
            => src.Data.Equals(Data);
        
        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash();
        
        public static MemRef Empty 
            => new MemRef(default(Vector128<ulong>));
    }
}