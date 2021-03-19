//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;

    using static Part;


    class NatSpanCases
    {
        public static IEnumerable<(OpIdentity id, Type type)> All
            => from p in typeof(NatSpanCases).Properties().Where(p => p.Name != nameof(All))
                let id = OpIdentityParser.parse(p.DisplayName())
                let type = p.PropertyType
                select (id,type);

        [DisplayName("n4x32u")]
        public static NatSpan<N4,uint> Case_n4x32u
            => NatSpan.alloc(n4,Konst.z32);

        [DisplayName("n128x64u")]
        public static NatSpan<N128,ulong> Case_n128x64u
            => NatSpan.alloc(n128,Konst.z64);

        [DisplayName("n256x1u")]
        public static NatSpan<N256,Bit32> Case_n128x1u
            => NatSpan.alloc<N256,Bit32>();
    }
}