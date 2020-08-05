//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    public readonly struct Publications : IPublicationArchive
    {
        public static IPublicationArchive Default => default;
    }    
}