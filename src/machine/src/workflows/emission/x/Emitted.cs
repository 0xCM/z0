//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        public static void Emitted(this EmissionDataType mk, IAppEventSink dst)
            => PartDataEmitters.emitting(mk, dst);

        public static void Emitted(this PartRecordKind rk, PartId part, IAppEventSink dst)
            => PartDataEmitters.emitted(rk, part, dst);
    }
}