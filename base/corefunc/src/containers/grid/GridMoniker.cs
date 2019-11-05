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

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct GridMoniker
    {
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
        public static GridMoniker Define(ulong id)
            => Unsafe.As<ulong,GridMoniker>(ref id);

        [MethodImpl(Inline)]
        public GridMoniker(ushort rows, ushort cols, ushort segwidth)
        {
            this.RowCount = rows;
            this.ColCount = cols;
            this.SegWidth = segwidth;
            this.Filler = 0;
        }

        public readonly ushort RowCount;
        
        public readonly ushort ColCount;
        
        public readonly ushort SegWidth;

        readonly ushort Filler;

        /// <summary>
        /// Presents the moniker as an integer 
        /// </summary>
        public ulong Identifier
            => Unsafe.As<GridMoniker, ulong>(ref As.asRef(in this));

        /// <summary>
        /// Presents the moniker as text
        /// </summary>
        public string Text
            => $"{RowCount}x{ColCount}x{SegWidth}";

        public override string ToString()
            => Text;
    }

}