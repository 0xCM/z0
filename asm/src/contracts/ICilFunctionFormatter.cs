//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static zfunc;

    public interface ICilFunctionFormatter
    {
        string Format(CilFunction f);
    }
}