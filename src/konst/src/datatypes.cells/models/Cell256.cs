//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Part;
    using static z;

    using F = Cell256;
    using api = Cells;

    public readonly struct Cell256 : IDataCell<Cell256,W256,Vector256<ulong>>
    {
        public Vector256<ulong> Content {get;}

        [MethodImpl(Inline)]
        public Cell256(Vector256<ulong> src)
            => Content = src;

        public CellKind Kind => CellKind.Cell256;


        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => api.bytes(this);
        }

        public Cell128 Lo
        {
            [MethodImpl(Inline)]
            get => Vector256.GetLower(Content);
        }

        public Cell128 Hi
        {
            [MethodImpl(Inline)]
            get => Vector256.GetUpper(Content);
        }

        public int BitWidth => 256;

        public int Size => 32;

        public Cell256 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public static Cell256 init<T>(Vector256<T> src)
            where T : unmanaged
                => new Cell256(v64u(src));

        [MethodImpl(Inline)]
        public static Cell256 init<T>(Vector128<T> a, Vector128<T> b)
            where T : unmanaged
        {
            var c = z.vinsert(gcpu.v64u(a), default, LaneIndex.L0);
            return new Cell256(z.vinsert(gcpu.v64u(b),c,LaneIndex.L1));
        }

        [MethodImpl(Inline)]
        public static Cell256 init(Cell128 a, Cell128 b)
        {
            var a1 = a.ToVector<ulong>();
            var b1 = b.ToVector<ulong>();
            var c = vinsert(a1, default, 0);
            return new Cell256(vinsert(b1, c, 1));
        }

        [MethodImpl(Inline)]
        public bool Equals(Cell256 src)
            => Content.Equals(src.Content);

        [MethodImpl(Inline)]
        public bool Equals(Vector256<ulong> src)
            => Content.Equals(src);

        [MethodImpl(Inline)]
        public Vector256<T> ToVector<T>()
            where T : unmanaged
                => Content.As<ulong,T>();

        [MethodImpl(Inline)]
        public T As<T>()
             where T : struct
               => In.generic<F,T>(this);
       public string Format()
            => Content.ToString();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Content.GetHashCode();

        public override bool Equals(object src)
            => src is Cell256 x && Equals(x);

        [MethodImpl(Inline), Op]
        static Vector256<ulong> vinsert(Vector128<ulong> src, Vector256<ulong> dst, [Imm] byte index)
            => InsertVector128(dst, src, index);

        [MethodImpl(Inline)]
        public static implicit operator Cell256((Cell128 x, Cell128 y) src)
            => init(src.x,src.y);

        [MethodImpl(Inline)]
        public static implicit operator Cell256(Vector256<byte> x)
            => init(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell256(Vector256<ushort> x)
            => init(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell256(Vector256<uint> x)
            => init(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell256(Vector256<ulong> x)
            => init(x);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<byte>(Cell256 x)
            => x.Content.AsByte();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ushort>(Cell256 x)
            => x.Content.AsUInt16();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<uint>(Cell256 x)
            => x.Content.AsUInt32();

        [MethodImpl(Inline)]
        public static implicit operator Vector256<ulong>(Cell256 x)
            => x.Content.AsUInt64();

        public static Cell256 Empty => default;
    }
}