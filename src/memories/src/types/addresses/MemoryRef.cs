//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Seed;

    public readonly struct MemoryRef : IAddressable<MemoryRef>, ITextual, IEquatable<MemoryRef>
    {
        public static MemoryRef Empty => new MemoryRef(default(Vector128<ulong>));
        
        readonly Vector128<ulong> Data;        
        
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
            => Spans.read(Address, Length);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Load<T>()
            => Spans.read<T>(Address, Length);
       
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