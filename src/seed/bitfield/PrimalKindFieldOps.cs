//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    using static PrimalKindSpecs;

    readonly struct PrimalKindFieldOps
    {
        public static PrimalKindFieldOps Service => default;
        
        static PrimalKinds api => PrimalKinds.Service;

        [MethodImpl(Inline), Op]
        public PrimalWidthL2 Width(PrimalKindField f)
            => (PrimalWidthL2)api.SegData(f, Field.Width);

        [MethodImpl(Inline), Op]
        public PrimalKindId KindId(PrimalKindField f)
            => (PrimalKindId)api.SegData(f, Field.KindId);

        [MethodImpl(Inline), Op]
        public Sign8 Sign(PrimalKindField f)
            => (Sign8)api.SegData(f, Field.Sign);
    }
}