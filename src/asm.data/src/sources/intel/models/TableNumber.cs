//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public readonly struct TableNumber
        {
            public const string Marker = "Table ";

            readonly CharBlock8 _Data;

            [MethodImpl(Inline)]
            public TableNumber(CharBlock8 data)
            {
                _Data = data;
            }

            public ReadOnlySpan<char> Data
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            public static TableNumber Empty
            {
                [MethodImpl(Inline)]
                get => new TableNumber(CharBlock8.Null);
            }

            [MethodImpl(Inline)]
            public static int MarkerIndex(ReadOnlySpan<char> src)
            {
                var index = src.IndexOf(Marker);
                if(index > Marker.Length)
                    return NotFound;
                else
                    return index;
            }

            public string Format()
                => string.Format("{0}{1}", Marker, _Data.Format());

            public override string ToString()
                => Format();

        }
    }
}