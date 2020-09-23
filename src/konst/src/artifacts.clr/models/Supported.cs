//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct ClrArtifacts
    {
        public readonly struct Supported
        {
            public static AssemblyView assembly => default;

            public static FieldView field => default;

            public static MethodView method => default;

            public static TypeView type => default;

            public static ModuleView module => default;
        }

        static AssemblyView assembly => Supported.assembly;

        static FieldView field => Supported.field;

        static ModuleView module => Supported.module;

        static MethodView method => Supported.method;

        static TypeView type => Supported.type;
    }
}