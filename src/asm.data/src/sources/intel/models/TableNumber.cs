//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public readonly struct TableNumber
        {
            internal const string Marker = "Table ";

            internal const char Sep = Chars.Dash;

            internal const byte MarkerLength = 6;

            internal const string RenderPattern = Marker + "{0}-{1}";

            internal const char Delimiter = Chars.Dash;

            public char Major {get;}

            public ushort Minor {get;}

            [MethodImpl(Inline)]
            public TableNumber(char major, ushort minor)
            {
                Major = major;
                Minor = minor;
            }

            public override string ToString()
                => string.Format(RenderPattern, Major, Minor);

            public static TableNumber Empty
            {
                [MethodImpl(Inline)]
                get => new TableNumber('\0',0);
            }
        }
    }
}