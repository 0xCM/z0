//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    partial class RootX
    {    
        public static IOperationCatalog OperationCatalog(this Assembly a)
            => a.Designator().Catalog;

    }
}