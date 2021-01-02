//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.Sigs, true)]
    public readonly struct ApiSigs
    {
        [Op, Closures(AllNumeric)]
        public static ApiSig define<T>(PartId part, string host, T @class)
            where T : unmanaged
                => new ApiSig(new dynamic[3]{part, @class, host});

        [MethodImpl(Inline)]
        public static ApiSig define<T,A0>(PartId part, string host, T @class)
            where T : unmanaged
                => new ApiSig(new dynamic[4]{part, host, @class, typeof(A0)});

        [MethodImpl(Inline)]
        public static ApiSig define<T,A0,A1>(PartId part, string host, T @class)
            where T : unmanaged
                => new ApiSig(new dynamic[5]{part, host, @class, typeof(A0), typeof(A1)});

        [MethodImpl(Inline)]
        public static ApiSig define<T,A0,A1,A2>(PartId part, string host, T @class)
            where T : unmanaged
                => new ApiSig(new dynamic[6]{part, host, @class, typeof(A0), typeof(A1), typeof(A2)});

    }
}