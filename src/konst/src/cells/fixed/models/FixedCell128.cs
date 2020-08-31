//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    using F = FixedCell128;

    public readonly struct FixedCell128 : IFixedCellW<F,W128,Vector128<ulong>>
    {
        internal readonly Vector128<ulong> Data;

        public Vector128<ulong> Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ulong Lo
        {
            [MethodImpl(Inline)]
            get => Data.GetElement(0);
        }

        public ulong Hi
        {
            [MethodImpl(Inline)]
            get => Data.GetElement(1);
        }

        public FixedCell128 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public static FixedCell128 From<T>(Vector128<T> src)
            where T : unmanaged
                => new FixedCell128(v64u(src));

        [MethodImpl(Inline)]
        public static FixedCell128 From((ulong x0, ulong x1) x)
            => new FixedCell128(x.x0,x.x1);

        [MethodImpl(Inline)]
        public static FixedCell128 From(in ConstPair<ulong> x)
            => new FixedCell128(x.Left,x.Right);

        [MethodImpl(Inline)]
        public FixedCell128(Vector128<ulong> src)
            => Data = src;

        [MethodImpl(Inline)]
        FixedCell128(ulong x0, ulong x1)
        {
            Data = Vector128.Create(x0,x1);
        }

        [MethodImpl(Inline)]
        public static implicit operator FixedCell128((ulong x0, ulong x1) x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell128(in ConstPair<ulong> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell128(Vector128<byte> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell128(Vector128<ushort> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell128(Vector128<uint> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell128(Vector128<ulong> x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<byte>(FixedCell128 x)
            => x.Data.AsByte();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ushort>(FixedCell128 x)
            => x.Data.AsUInt16();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<uint>(FixedCell128 x)
            => x.Data.AsUInt32();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(FixedCell128 x)
            => x.Data.AsUInt64();

        [MethodImpl(Inline)]
        public bool Equals(FixedCell128 src)
            => Data.Equals(src.Data);

        [MethodImpl(Inline)]
        public bool Equals(Vector128<ulong> src)
            => Data.Equals(src);

        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
                => In.generic<F,T>(this);

        [MethodImpl(Inline)]
        public Vector128<T> ToVector<T>()
            where T : struct
                => Data.As<ulong,T>();
        public string Format()
            => Data.ToString();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is FixedCell128 x && Equals(x);

        public static FixedCell128 Empty
            => default;
    }
}