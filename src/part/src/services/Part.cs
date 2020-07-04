//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    [ApiHost]
    public readonly partial struct Part
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
                
        [MethodImpl(Inline), Op]
        public static PartId withoutTest(PartId a)
            => a & ~ PartId.Test;

        [MethodImpl(Inline), Op]
        public static PartId withTest(PartId a)
            => a | PartId.Test;

        [MethodImpl(Inline), Op]
        public static PartId withoutSvc(PartId a)
            => a & ~ PartId.Svc;

        [MethodImpl(Inline), Op]
        public static PartId withSvc(PartId a)
            => a | PartId.Svc;
    }
}