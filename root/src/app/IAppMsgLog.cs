//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using static Root;

    public interface IAppMsgLog : IAppMsgSink
    {
        void Write(IEnumerable<AppMsg> src);
        
        void Write(AppMsg src);
        
        void ISink<AppMsg>.Accept(in AppMsg src)
            => Write(src);
    }    
}