//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    
    using static Textual;

    public static class HexFormatExtensions
    {
        public static string Format(this MemoryExtract src)
            => src.Bytes.FormatHex();

        public static string Format(this MemoryRange src)
            => text.bracket(text.concat(src.Start.Format(), text.comma(), text.space(), src.End.Format()));
    }
}