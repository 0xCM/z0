//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;
    using static z;

    /// <summary>
    /// Captures a dependency relationship between two assemblies
    /// </summary>
    [Table(TableId, FieldCount)]
    public struct AssemblyDependency
    {
        public const string TableId = "cli.assemblyref";

        public const byte FieldCount = 2;

        public AssemblyName Source;

        public AssemblyName Target;
    }
}