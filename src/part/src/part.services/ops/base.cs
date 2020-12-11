//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Part
    {
        [MethodImpl(Inline), Op]
        public static PartId @base(PartId a)
            => withoutTest(withoutSvc(a));
    }
}