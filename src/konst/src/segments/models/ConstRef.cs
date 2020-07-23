//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a content-parametric view over a memory reference
    /// </summary>
    public readonly struct ConstRef<T>
    {
        readonly Ref R;
        
        /// <summary>
        /// Dereferences the reference
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> operator !(ConstRef<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Ref(ConstRef<T> src)
            => src.R;

        [MethodImpl(Inline)]
        public static implicit operator ConstRef<T>(Ref src)
            => new ConstRef<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ConstRef<T>(Ref<T> src)
            => new ConstRef<T>(src.Segment);

        [MethodImpl(Inline)]
        public static bool operator ==(ConstRef<T> lhs, ConstRef<T> rhs)
            => lhs.Equals(rhs);
        
        [MethodImpl(Inline)]
        public static bool operator !=(ConstRef<T> lhs, ConstRef<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public ConstRef(Ref src)
            => R = src;

        public ReadOnlySpan<T> Data
        {
            [MethodImpl(Inline)]
            get => R.As<T>();
        }
        
        public ReadOnlySpan<byte> Buffer
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
        public unsafe ref readonly T Cell(int index)
            => ref Unsafe.AsRef<T>((void*)(Location + (uint)index*CellSize));

        public ref readonly T this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<S> As<S>()
            => R.As<S>();

        [MethodImpl(Inline)]
        public bool Equals(ConstRef<T> src)
            => R.Equals(src.R);

        public override bool Equals(object src)        
            => src is ConstRef<T> r && Equals(r);
        
        public override int GetHashCode()
            => (int)Location;

        public static ConstRef<T> Empty 
            => default;
             
    }
}