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

    public interface ILogDevice : IAppServiceAlloction
    {
        void Write<F>(F formattable)
            where F : ICustomFormattable;  

        void Write<F>(F[] formattables)
            where F : ICustomFormattable;  

    }
}