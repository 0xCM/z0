﻿//-------------------------------------------------------------------------------------------
// OSS developed by Chris Moore and licensed via MIT: https://opensource.org/licenses/MIT
// This license grants rights to merge, copy, distribute, sell or otherwise do with it 
// as you like. But please, for the love of Zeus, don't clutter it with regions.
//-------------------------------------------------------------------------------------------
namespace Meta.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static metacore;

    public interface ISysOpProvider : IApplicationService
    {
        Option<IOperationProvider> RequestOperationSet(Type ComponentType, SystemNode ActiveNode);


        Option<S> RequestOperationSet<S>(SystemNode ActiveNode)
            where S : SysOpComponent<S>;

    }



}