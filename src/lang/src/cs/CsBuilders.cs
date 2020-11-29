//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang.Cs
{
    using System;
    using System.Runtime.CompilerServices;

    using static ModelKinds;
    using static Konst;

    using K = Microsoft.CodeAnalysis.OperationKind;

    [ApiHost(ApiNames.CsBuilder)]
    public ref struct CsBuilders
    {
        internal ReadOnlySpan<K> OpKinds;

        [MethodImpl(Inline)]
        public static CsBuilders init()
        {
            var dst = new CsBuilders();
            dst.OpKinds = Enums.literals<K>();
            return dst;
        }
    }
}