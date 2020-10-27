//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    using static Konst;
    using static z;

    partial struct JsonDeps
    {
        public struct ProjectDependency
        {
            public string AssemblyName;

            public string AssemblyVersion;
        }
    }
}