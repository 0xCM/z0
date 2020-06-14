//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EnumData
    {
        public FilePath Source {get;}

        public readonly EnumLiteralData[] Literals;

        public static EnumData Empty 
            => new EnumData(FilePath.Empty, Array.Empty<EnumLiteralData>());

        [MethodImpl(Inline)]
        public EnumData(FilePath src, EnumLiteralData[] literals)
        {
            Source = src;
            Literals = literals;
        }
    }
}