//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class SkipAttribute : Attribute
    {

    }

}