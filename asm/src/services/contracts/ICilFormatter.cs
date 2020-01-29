//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static zfunc;

    public interface ICilFormatter
    {
        string Format(CilFunction f);
    }
}