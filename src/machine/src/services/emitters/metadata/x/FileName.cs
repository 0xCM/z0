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
        public static FileName FileName(this EmissionDataType mk, PartRecordKind rk)
            => MetadataEmitters.filename(mk, rk);        

        public static FileExtension Ext(this EmissionDataType mk)
            => MetadataEmitters.ext(mk);

        public static void Status(this WfKind kind, WfStatusKind status, IAppEventSink dst)
            => MetadataEmitters.status(kind, status, dst);                            
    }
}