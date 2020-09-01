//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct ImageRecords
    {
        public static ImageStringRecord Strings => default;

        public static ImageConstantRecord Constants => default;

        public static ImageFieldTable Fields => default;

        public static FieldRvaRecord FieldRva => default;

    }
}