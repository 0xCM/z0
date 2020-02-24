//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface IMsgLog
    {
        void Write(IEnumerable<AppMsg> src);
        
        void Write(AppMsg src);
    }
}