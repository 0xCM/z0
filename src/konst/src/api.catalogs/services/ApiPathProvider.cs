//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static memory;

    sealed class ApiPathProvider : WfService<ApiPathProvider, IApiPathProvider>, IApiPathProvider
    {
        protected override void OnInit()
        {
            Root = Db.CaptureRoot();
        }

        public FS.FolderPath Root {get; private set;}
    }
}