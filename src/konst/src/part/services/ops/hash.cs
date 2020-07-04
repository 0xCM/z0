//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    partial struct Part
    {
        [MethodImpl(Inline), Op]
        public static uint hash(PartId src)
            => (uint)src;
    }
}