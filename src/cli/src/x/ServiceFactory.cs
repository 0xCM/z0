//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XSvc
    {
        public static ImageDataEmitter ImageDataEmitter(this IWfShell wf)
            => Z0.ImageDataEmitter.create(wf);
    }
}