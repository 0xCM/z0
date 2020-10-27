//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    partial struct JsonDeps
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Options
        {
            public IndexedView<string> Defines;

            public string LanguageVersion;

            public string Platform;

            public bool? AllowUnsafe;

            public bool? WarningsAsErrors;

            public bool? Optimize;

            public string KeyFile;

            public bool? DelaySign;

            public bool? PublicSign;

            public string DebugType;

            public bool? EmitEntryPoint;

            public bool? GenerateXmlDocumentation;
        }

        public struct LibDependency
        {
            public string Name;

            public string Version;
        }
    }
}