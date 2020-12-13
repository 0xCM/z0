//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ApiIdentify
    {
        public static Option<TypeIndicator> SegIndicator(Type t)
        {
            if(t.IsBlocked())
                return TypeIndicator.Define(IDI.Block);
            else if(t.IsVector())
                return TypeIndicator.Define(IDI.Vector);
            else
                return Option.none<TypeIndicator>();
        }

        [MethodImpl(Inline), Op]
        public static PartId part(Type src)
            => src.Assembly.Id();
    }
}