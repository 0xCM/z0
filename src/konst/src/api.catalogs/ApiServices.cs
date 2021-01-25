//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class ApiServices : WfService<ApiServices, ApiServices>
    {
        public IApiJit ApiJit()
            => ApiJitService.create(Wf);
    }
}