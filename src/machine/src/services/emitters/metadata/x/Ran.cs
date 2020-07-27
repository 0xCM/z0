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
        public static void Ran(this FolderPath path, IAppEventSink dst)        
            => MetadataEmitters.ran(path, dst);

        public static void Ran(this PartRecordKind rk, IAppEventSink dst)
            => MetadataEmitters.ran(rk, dst);
    }
}