//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    public interface IListPublisher
    {
        void PublishList<E>(Dictionary<string,E> src, string name)
            where E : unmanaged, Enum;

        void PublishList<E>()
            where E : unmanaged, Enum;            
    }
}