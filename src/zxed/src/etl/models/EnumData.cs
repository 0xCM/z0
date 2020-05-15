//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct EnumData
    {
        public static EnumData Empty => new EnumData(FilePath.Empty, Control.array<EnumLiteralData>());

        public FilePath Source {get;}

        public readonly EnumLiteralData[] Literals;

        [MethodImpl(Inline)]
        public EnumData(FilePath src, EnumLiteralData[] literals)
        {
            Source = src;
            Literals = literals;
        }
    }
}