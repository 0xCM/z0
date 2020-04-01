//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Security;

    public interface IMessageLog<M> : IMessageSink<M>
        where M : IAppMsg
    {
        void Write(IEnumerable<M> src);
        
        void Write(M src);

        void ISink<M>.Accept(in M src)
            => Write(src);
    }        

}