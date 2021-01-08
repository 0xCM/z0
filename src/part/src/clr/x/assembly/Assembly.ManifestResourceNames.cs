//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XClrQuery
    {
        [MethodImpl(Inline)]
        public static string[] ManifestResourceNames(this Assembly src)
            => src.GetManifestResourceNames() ?? sys.empty<string>();
    }
}