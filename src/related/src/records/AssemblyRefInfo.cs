//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct Images
    {
        /// <summary>
        /// Captures a dependency relationship between two assemblies
        /// </summary>
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefInfo : IRecord<AssemblyRefInfo>
        {
            public const string TableId = "cli.assemblyref";

            public Name Source;

            public Name Target;

            public BinaryCode Token;
        }
    }
}