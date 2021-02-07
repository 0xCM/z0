//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    using F = Cell128;
    using api = Cells;

    [Datatype("m128")]
    public readonly struct Cell128 : IDataCell<F,W128,Vector128<ulong>>
    {
        readonly Vector128<ulong> Data;

        [MethodImpl(Inline)]
        public Cell128(Vector128<ulong> src)
            => Data = src;

        [MethodImpl(Inline)]
        public Cell128(ulong x0, ulong x1)
            => Data = cpu.vparts(w128, x0,x1);

        public CellKind Kind
            => CellKind.Cell128;

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

        public Cell128 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(Cell128 src)
            => Data.Equals(src.Data);

        [MethodImpl(Inline)]
        public bool Equals(Vector128<ulong> src)
            => Data.Equals(src);

        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
                => memory.@as<F,T>(this);

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
            => src is Cell128 x && Equals(x);

        public static Cell128 Empty
            => default;

        [MethodImpl(Inline)]
        public static implicit operator Cell128((ulong x0, ulong x1) x)
            => api.cell128(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell128(in ConstPair<ulong> x)
            => api.cell128(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell128(Vector128<byte> x)
            => gcells.cell128(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell128(Vector128<ushort> x)
            => gcells.cell128(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell128(Vector128<uint> x)
            => gcells.cell128(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell128(Vector128<ulong> x)
            => new Cell128(x);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<byte>(Cell128 x)
            => x.Data.AsByte();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<sbyte>(Cell128 x)
            => x.Data.AsSByte();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ushort>(Cell128 x)
            => x.Data.AsUInt16();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<short>(Cell128 x)
            => x.Data.AsInt16();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<int>(Cell128 x)
            => x.Data.AsInt32();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<uint>(Cell128 x)
            => x.Data.AsUInt32();

       [MethodImpl(Inline)]
        public static implicit operator Vector128<long>(Cell128 x)
            => x.Data.AsInt64();

        [MethodImpl(Inline)]
        public static implicit operator Vector128<ulong>(Cell128 x)
            => x.Data.AsUInt64();
    }
}