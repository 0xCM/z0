//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    
    public interface ICilFunctionFormatter : ICilService
    {
        string Format(CilFunction f);
    }
}