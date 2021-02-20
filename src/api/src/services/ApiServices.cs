//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    sealed class ApiServices : WfService<ApiServices,IApiServices>, IApiServices
    {
        public IApiJit ApiJit()
            => Z0.ApiJit.create(Wf);
    }
}