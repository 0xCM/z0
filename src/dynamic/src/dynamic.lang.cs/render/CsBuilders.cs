//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang.Cs
{
    using System;

    using static ModelKinds;

    using K =Microsoft.CodeAnalysis.OperationKind;

    [ApiHost(ApiNames.CsBuilder)]
    public ref struct CsBuilders
    {
        internal ReadOnlySpan<K> OpKinds;

        public static CsBuilders init()
        {
            var dst = new CsBuilders();
            dst.OpKinds = Enums.literals<K>();
            return dst;
        }

        public static SwitchMap<C,T> build<C,T>(SwitchMap k, Identifier name, Tests<C,T> cases)
            => new SwitchMap<C,T>(name,cases);
    }
}