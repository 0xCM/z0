//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct GridMoniker<T>
        where T : unmanaged
    {
        /// <summary>
        /// The number of rows in the grid
        /// </summary>
        public readonly ushort RowCount;
        
        /// <summary>
        /// The number of columns in the grid
        /// </summary>
        public readonly ushort ColCount;

        /// <summary>
        /// The bit-width of a storage segment
        /// </summary>
        public ushort SegWidth
        {
            [MethodImpl(Inline)]
            get => (ushort)bitsize<T>();
        }

        /// <summary>
        /// The untyped presentation of the moniker
        /// </summary>
        public GridMoniker Untyped
        {
            [MethodImpl(Inline)]
            get => this;
        }

        /// <summary>
        /// The total number of points covered by the grid
        /// </summary>
        public int PointCount
        {
            [MethodImpl(Inline)]
            get => Untyped.PointCount;
        }

        /// <summary>
        /// The moniker encoded as a 64-bit integer
        /// </summary>
        public ulong Identifier
        {
            [MethodImpl(Inline)]
            get => Untyped.Identifier;
        }

        [MethodImpl(Inline)]
        public static implicit operator GridMoniker(GridMoniker<T> src)
            => GridMoniker.FromSpecs(src.RowCount, src.ColCount, src.SegWidth);
        
        [MethodImpl(Inline)]
        public static bool operator ==(GridMoniker<T> a, GridMoniker<T> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(GridMoniker<T> a, GridMoniker<T> b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public GridMoniker(ushort rows, ushort cols)
        {
            this.RowCount = rows;
            this.ColCount = cols;
        }

        [MethodImpl(Inline)]
        public bool Equals(GridMoniker<T> rhs)
            => Identifier == rhs.Identifier;
                           
        /// <summary>
        /// Presents the moniker as text
        /// </summary>
        public string Text
            => $"{RowCount}x{ColCount}x{SegWidth}";

        public override string ToString()
            => Text;

        public override int GetHashCode()
            => Identifier.GetHashCode();

        public override bool Equals(object rhs)
            => rhs is GridMoniker<T> x && Equals(x);
    }

    /// <summary>
    /// Identifies and characterizes a bit grid
    /// </summary>
    public readonly struct GridMoniker
    {        
        /// <summary>
        /// The number of rows in the grid
        /// </summary>
        public readonly ushort RowCount;
        
        /// <summary>
        /// The number of columns in the grid
        /// </summary>
        public readonly ushort ColCount;
        
        /// <summary>
        /// The bit-width of a storage segment
        /// </summary>
        public readonly ushort SegWidth;

        /// <summary>
        /// Extends the struct to a width of 64 bits
        /// </summary>
        readonly ushort Filler;

        /// <summary>
        /// Defines a moniker predicated on type parameters
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="zero"></param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline)]
        public static GridMoniker<T> FromTypes<M,N,T>(M m = default, N n = default, T zero = default)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => new GridMoniker<T>(natval<M>(),natval<N>());

        /// <summary>
        /// Defines a moniker predicated on grid dimensions and storage segment width
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="segwidth">The width of a storage segment</param>
        [MethodImpl(Inline)]
        public static GridMoniker FromSpecs(int rows, int cols, int segwidth)
            => new GridMoniker((ushort)rows, (ushort)cols, (ushort)segwidth);

        /// <summary>
        /// Defines a moniker predicated on grid dimensions and parametric storage type
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline)]
        public static GridMoniker<T> FromDim<T>(ushort rows, ushort cols)
            where T : unmanaged
                => new GridMoniker<T>(rows,cols);

        /// <summary>
        /// Defines a moniker predicated on grid dimensions and parametric storage type
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline)]
        public static GridMoniker<T> FromDim<T>(int rows, int cols)
            where T : unmanaged
                => new GridMoniker<T>((ushort)rows,(ushort)cols);

        /// <summary>
        /// Defines a moniker predicated on its integral identifier
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline)]
        public static GridMoniker FromId(ulong id)
            => Unsafe.As<ulong,GridMoniker>(ref id);

        public static Option<GridMoniker> Parse(string text)
        {
            var parts = text.Split('x');
            if(parts.Length == 3)
            {
                if(ushort.TryParse(parts[0], out var rows))
                if(ushort.TryParse(parts[1], out var cols))
                if(ushort.TryParse(parts[2], out var segwidth))
                    return new GridMoniker(rows,cols,segwidth);
            }
            return default;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(GridMoniker a, GridMoniker b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(GridMoniker a, GridMoniker b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public GridMoniker(ushort rows, ushort cols, ushort segwidth)
        {
            this.RowCount = rows;
            this.ColCount = cols;
            this.SegWidth = segwidth;
            this.Filler = 0;
        }

        /// <summary>
        /// The total number of points covered by the grid
        /// </summary>
        public int PointCount
        {
            [MethodImpl(Inline)]
            get => RowCount * ColCount;
        }

        /// <summary>
        /// The moniker encoded as a 64-bit integer
        /// </summary>
        public ulong Identifier
        {
            [MethodImpl(Inline)]
            get => Unsafe.As<GridMoniker, ulong>(ref mutable(in this));
        }

        [MethodImpl(Inline)]
        public bool Equals(GridMoniker rhs)
            => Identifier == rhs.Identifier;
                   
        /// <summary>
        /// Presents the moniker as text
        /// </summary>
        public string Text
            => $"{RowCount}x{ColCount}x{SegWidth}";

        public override string ToString()
            => Text;

        public override int GetHashCode()
            => Identifier.GetHashCode();

        public override bool Equals(object rhs)
            => rhs is GridMoniker x && Equals(x);
    }
}