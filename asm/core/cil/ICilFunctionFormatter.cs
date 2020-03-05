//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface ICilFunctionFormatter : IAsmService
    {
        string Format(CilFunction f);
    }
}