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
    using static V0;
    using static As;

    public readonly struct MemRef : IAddressable<MemRef>, ITextual, IEquatable<MemRef>
    {
        readonly Vector128<ulong> Data;        
        
        [MethodImpl(Inline)]
        public unsafe static MemRef from(ReadOnlySpan<byte> src)
            => new MemRef(gptr(first(src)), src.Length);
                
        ulong Lo
        {
            [MethodImpl(Inline)]
            get => vcell(Data,0);
        }

        ulong Hi
        {
            [MethodImpl(Inline)]
            get => vcell(Data,1);
        }

        public MemoryAddress Address 
        {
            [MethodImpl(Inline)]
            get => Lo;
        }
        
        public MemoryRange Segment
        {
            get => new MemoryRange(Address, Address + Hi);
        }
        
        /// <summary>
        /// Specifies the segment byte count
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        public ByteSize Length 
        {
            [MethodImpl(Inline)]
            get => (uint)Hi;
        }

        /// <summary>
        /// Computes the whole number of T-cells covered by segment
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public int Count<T>()
            => Length/Root.size<T>();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(in MemRef src)
            => src.Data;

        [MethodImpl(Inline)]
        internal MemRef(Vector128<ulong> src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public unsafe MemRef(byte* src, int length)
        {
            Data = vparts((ulong)src, (ulong)length);
        }

        [MethodImpl(Inline)]
        public MemRef(MemoryAddress src, int length)
        {
            Data = vparts((ulong)src, (ulong)length);
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
            => Root.view<byte>(this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Load<T>()
            => Root.view<T>(this);

        [MethodImpl(Inline)]
        public unsafe T* Pointer<T>()
            where T : unmanaged
                => Address.Pointer<T>();

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