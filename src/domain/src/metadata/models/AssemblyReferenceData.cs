//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public readonly partial struct ClrData
    {
        /// <summary>
        /// Captures <see cref='AssemblyReference'/> data in usable form
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyReferenceData
        {
            public string Culture;

            public AssemblyFlags Flags;

            public BinaryCode HashValue;

            public string Name;

            public BinaryCode PublicKeyOrToken;

            public Version Version;

            public AssemblyName AssemblyName;
        }
    }
}