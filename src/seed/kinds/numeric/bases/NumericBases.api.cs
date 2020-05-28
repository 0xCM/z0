//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [ApiHost]
    public partial class NumericBases : IApiHost<NumericBases>
    {
        public static Base2 Base2 => default;

        public static Base3 Base3 => default;

        public static Base8 Base8 => default;

        public static Base10 Base10 => default;

        public static Base16 Base16 => default;
    }
}