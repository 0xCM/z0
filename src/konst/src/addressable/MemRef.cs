//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.Vector128;

    using static Konst;

    public readonly struct MemRef : IAddress<MemoryAddress>, ITextual, IEquatable<MemRef>
    {
        internal readonly Vector128<ulong> Data;        
                        
        [MethodImpl(Inline)]
        public unsafe static MemRef from(ReadOnlySpan<byte> src)
            => new MemRef(core.gptr(core.first(src)), src.Length);

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Lo;
        }

        public uint Width
        {
            [MethodImpl(Inline)]
            get => 64;
        }        

        public MemoryRange Segment
        {
            [MethodImpl(Inline)]
            get => new MemoryRange(Address, Address + Hi);
        }
        
        /// <summary>
        /// Specifies the segment byte count
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        public uint DataSize 
        {
            [MethodImpl(Inline)]
            get => (uint)Hi;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(in MemRef src)
            => src.Data;

        [MethodImpl(Inline)]
        public MemRef(ulong location, uint size)
            => Data = vparts(location, (ulong)size);

        [MethodImpl(Inline)]
        public MemRef(Vector128<ulong> src)
            => Data = src;

        [MethodImpl(Inline)]
        public unsafe MemRef(byte* src, int length)
            =>  Data = vparts((ulong)src, (ulong)length);

        [MethodImpl(Inline)]
        public MemRef(MemoryAddress src, int length)
            => Data = vparts((ulong)src, (ulong)length);

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

        /// <summary>
        /// Computes the whole number of T-cells covered by segment
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public int Count<T>()
            => (int)(DataSize/core.size<T>());

        [MethodImpl(Inline)]
        public string Format()
            => Address.Format();
        
        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> Load()
            => view<byte>(this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Load<T>()
            => view<T>(this);

        [MethodImpl(Inline)]
        public unsafe T* Pointer<T>()
            where T : unmanaged
                => Address.Pointer<T>();

        [MethodImpl(Inline)]
        public uint Hash()
            => core.hash(Lo, Hi);
        
        [MethodImpl(Inline)]
        public bool Equals(MemRef src)
            => src.Data.Equals(Data);
        
        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash();

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
       
        MemoryAddress IAddress<MemoryAddress>.Location
        {
            [MethodImpl(Inline)]
            get => Lo;
        }

        public static MemRef Empty 
            => new MemRef(default(Vector128<ulong>));

        /// <summary>
        /// Extracts an index-identified component from the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        static T vcell<T>(Vector128<T> src, int index)
            where T : unmanaged
                => src.GetElement(index);

        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline)]
        static Vector128<ulong> vparts(ulong x0, ulong x1)
            => Create(x0,x1);


        [MethodImpl(Inline)]
        static ReadOnlySpan<T> view<T>(in MemRef src)
            => core.cover(src.Address.Ref<T>(), src.Count<T>());

    }
}