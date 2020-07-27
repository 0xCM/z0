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
        public static void Emitting(this EmissionDataType dt, IAppEventSink dst)
            => MetadataEmitters.emitting(dt, dst);

        public static void Emitting(this EmissionDataType dt, FilePath path, IAppEventSink dst)
            => MetadataEmitters.emitting(dt, path, dst);

        public static void Emitting(this PartRecordKind dt,  FilePath path, IAppEventSink dst)
            => MetadataEmitters.emitting(dt, path, dst);
    }
}