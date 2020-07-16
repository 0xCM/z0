//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Ref<T> : IRef<Ref<T>,T>
    {
        internal readonly Ref R;

        /// <summary>
        /// Dereferences the reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline)]
        public static Span<T> operator !(Ref<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Ref(Ref<T> src)
            => src.R;

        [MethodImpl(Inline)]
        public static implicit operator Ref<T>(Ref src)
            => new Ref<T>(src);

        [MethodImpl(Inline)]
        public static bool operator ==(Ref<T> lhs, Ref<T> rhs)
            => lhs.Equals(rhs);
        
        [MethodImpl(Inline)]
        public static bool operator !=(Ref<T> lhs, Ref<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public Ref(Ref src)
            => R = src;
    
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => R.As<T>();
        }
        
        public Span<byte> Buffer
        {
            [MethodImpl(Inline)]
            get => R.Buffer; 
        }

        public uint DataSize
        {
            [MethodImpl(Inline)]
            get => R.DataSize;
        } 

        public uint CellSize 
        {
            [MethodImpl(Inline)]
            get => (uint)Unsafe.SizeOf<T>();
        }

        public uint CellCount
        {
            [MethodImpl(Inline)]
            get => DataSize/CellSize;
        }

        public ulong Location
        {
            [MethodImpl(Inline)]
            get => R.Location;
        }
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Location == 0 || DataSize == 0;
        }
        
        [MethodImpl(Inline)]
        public unsafe ref T Cell(int index)
            => ref Unsafe.AsRef<T>((void*)(Location + (uint)index*CellSize));

        public ref T this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }
    
        [MethodImpl(Inline)]
        public Span<S> As<S>()
            => R.As<S>();

        [MethodImpl(Inline)]
        public bool Equals(Ref<T> src)
            => R.Equals(src.R);

        public override bool Equals(object src)        
            => src is Ref<T> r && Equals(r);
        
        public override int GetHashCode()
            => (int) Location;

        public static Ref<T> Empty 
            => default;
    }
}