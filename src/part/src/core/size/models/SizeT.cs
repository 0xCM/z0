//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Sizes;

    public readonly struct Size<T> : IEquatable<Size<T>>
        where T : unmanaged
    {
        public T Measure {get;}

        [MethodImpl(Inline)]
        public Size(T measure)
        {
            Measure = measure;
        }

        public ByteSize Untyped
        {
            [MethodImpl(Inline)]
            get => api.untyped(this);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Untyped == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Untyped != 0;
        }

        public BitWidth Bits
        {
            [MethodImpl(Inline)]
            get => Untyped.Bits;
        }

        public Kb Kb
        {
            [MethodImpl(Inline)]
            get => Untyped.Kb;
        }

        public Mb Mb
        {
            [MethodImpl(Inline)]
            get => Untyped.Mb;
        }


        [MethodImpl(Inline)]
        public Size<T> Align(T factor)
            => Untyped.Align(Widths.pretend<T,ulong>(factor));

        [MethodImpl(Inline)]
        public bool Equals(Size<T> src)
            => Untyped.Equals(src.Untyped);

        [MethodImpl(Inline)]
        public int CompareTo(Size<T> src)
            => Untyped.CompareTo(src.Untyped);

        [MethodImpl(Inline)]
        public string Format()
            => Untyped.Format();


        public override bool Equals(object src)
            => src is Size<T> x && Equals(x);

        public override int GetHashCode()
            => Untyped.GetHashCode();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Size<T>(ByteSize src)
            => new Size<T>(Widths.pretend<ulong,T>((ulong)src));

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(Size<T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator Size<T>(T src)
            => new Size<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(Size<T> src)
            => src.Measure;

        [MethodImpl(Inline)]
        public static bool operator ==(Size<T> a, Size<T> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(Size<T> a, Size<T> b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static Size<T> operator +(Size<T> a, Size<T> b)
            => a.Untyped + b.Untyped;

        [MethodImpl(Inline)]
        public static Size<T> operator -(Size<T> a, Size<T> b)
            => a.Untyped - b.Untyped;

        [MethodImpl(Inline)]
        public static Size<T> operator *(Size<T> a, Size<T> b)
            => a.Untyped * b.Untyped;

        [MethodImpl(Inline)]
        public static Size<T> operator /(Size<T> a, Size<T> b)
            => a.Untyped/b.Untyped;

        [MethodImpl(Inline)]
        public static Size<T> operator %(Size<T> a, Size<T> b)
            => a.Untyped % b.Untyped;

        public static Size<T> Zero => default;
    }
}