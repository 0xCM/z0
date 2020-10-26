//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost("data.layouts")]
    public readonly partial struct DataLayouts
    {
        const NumericKind Closure = UnsignedInts;

        [Op]
        public static DataLayout<CorSigField> coresig()
        {
            var id = identify(0, CorSigField.None);
            var p0 = partition(0, CorSigField.CallingConvention, 0, 3);
            return specify(0, id, p0);
        }
    }
}