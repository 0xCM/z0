//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System;

    using static Konst;
    using static z;

    public readonly struct JsonDeps
    {
        public struct RuntimeTarget
        {
            public string Name;

            public string Signature;
        }

        public struct TargetReference
        {
            public string TargetName;

            public TargetMoniker[] Dependencies;
        }

        public struct Targets
        {
            public Target[] Items;
        }

        public struct Target
        {

        }

        public struct DependencyList
        {
            public TargetMoniker[] Items;
        }

        public struct TargetMoniker
        {
            public string Name;

            public string Version;
        }

        public struct TargetFile
        {
            public string ComponentName;

            public string AssemblyVersion;

            public string FileVersion;
        }
    }
}