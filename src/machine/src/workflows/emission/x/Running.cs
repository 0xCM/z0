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
        public static void Running(this FolderPath path, IAppEventSink dst)        
            => PartDataEmitters.running(path, dst);
    }
}