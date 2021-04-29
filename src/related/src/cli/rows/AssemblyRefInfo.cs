//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;
    using System.Runtime.InteropServices;

    partial struct Images
    {
        /// <summary>
        /// Captures a dependency relationship between two assemblies
        /// </summary>
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefInfo : IRecord<AssemblyRefInfo>
        {
            public const string TableId = "image.assemblyrefs";

            public AssemblyName Source;

            public AssemblyName Target;

            public BinaryCode Token;
        }
    }
}