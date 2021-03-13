//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ApiIdentity
    {
        [Op]
        public static Option<TypeIndicator> SegIndicator(Type t)
        {
            if(t.IsSegmented())
                return TypeIndicator.Define(IDI.Block);
            else if(t.IsVector())
                return TypeIndicator.Define(IDI.Vector);
            else
                return root.none<TypeIndicator>();
        }

        [MethodImpl(Inline), Op]
        public static PartId part(Type src)
            => src.Assembly.Id();
    }
}