//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        public static FileExtension Ext(this EmissionDataType mk)
            => PartDataEmitters.ext(mk);

        public static void Status(this WfKind kind, WfStatusKind status, IAppEventSink dst)
            => PartDataEmitters.status(kind, status, dst);                            
    }
}