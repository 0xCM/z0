//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public interface IConsoleNotifier
    {
        void NotifyConsole(IAppMsg msg);

        void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green);                    
    }

}