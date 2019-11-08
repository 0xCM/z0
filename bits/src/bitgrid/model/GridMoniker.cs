//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public readonly struct GridMoniker<T>
        where T : unmanaged
    {
        public readonly ushort RowCount;
        
        public readonly ushort ColCount;

        public ushort SegWidth
            => (ushort)bitsize<T>();

        public int PointCount
            => RowCount * ColCount;
        
        [MethodImpl(Inline)]
        public static implicit operator GridMoniker(GridMoniker<T> src)
            => GridMoniker.Define(src.RowCount, src.ColCount, src.SegWidth);
        
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

        public ulong Identifier
        {
            [MethodImpl(Inline)]
            get => (ulong)SegWidth << 32 | ((ulong)ColCount << 16) | RowCount; 
        }

        [MethodImpl(Inline)]
        public bool Equals(GridMoniker<T> rhs)
            => Identifier == rhs.Identifier;
                   
        public GridMoniker Untyped
        {
            [MethodImpl(Inline)]
            get => this;
        }                   
        
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
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public readonly struct GridMoniker
    {
        public readonly ushort RowCount;
        
        public readonly ushort ColCount;
        
        public readonly ushort SegWidth;

        readonly ushort Filler;

        public static Option<GridMoniker> Parse(string text)
        {
            var parts = text.Split('x');
            if(parts.Length == 3)
            {
                if(ushort.TryParse(parts[0], out var rows))
                if(ushort.TryParse(parts[0], out var cols))
                if(ushort.TryParse(parts[2], out var segwidth))
                    return new GridMoniker(rows,cols,segwidth);
            }
            return default;
        }

        [MethodImpl(Inline)]
        public static GridMoniker Define(ushort rows, ushort cols, ushort segwidth)
            => new GridMoniker(rows,cols,segwidth);

        [MethodImpl(Inline)]
        public static GridMoniker<T> Define<T>(ushort rows, ushort cols)
            where T : unmanaged
                => new GridMoniker<T>(rows,cols);

        [MethodImpl(Inline)]
        public static GridMoniker Define(ulong id)
            => Unsafe.As<ulong,GridMoniker>(ref id);

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
        /// Presents the moniker as an integer 
        /// </summary>
        public ulong Identifier
        {
            [MethodImpl(Inline)]
            get => Unsafe.As<GridMoniker, ulong>(ref As.asRef(in this));
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