//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Captures a dependency relationship between two assemblies
    /// </summary>
    [Record(TableId)]
    public struct AssemblyRefInfo : IRecord<AssemblyRefInfo>
    {
        public const string TableId = "cli.assemblyref";

        public const byte FieldCount = 2;

        public AssemblyName Source;

        public AssemblyName Target;
    }
}