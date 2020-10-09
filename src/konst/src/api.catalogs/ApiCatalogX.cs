//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    public static class ApiCatalogX
    {
        [MethodImpl(Inline)]
        public static MethodInfo[] ConcreteOperations(this IApiPartCatalog src)
            => src.Operations.Concrete();
    }
}