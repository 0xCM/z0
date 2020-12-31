//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct JsonDepsModel
    {
        public struct LibraryDependency
        {
            public string Name;

            public string Version;
        }
    }
}