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
        public static void Emitted(this EmissionDataType mk, IAppEventSink dst)
            => MetadataEmitters.emitting(mk, dst);

        public static void Emitted(this PartRecordKind rk, PartId part, IAppEventSink dst)
            => MetadataEmitters.emitted(rk, part, dst);
    }
}