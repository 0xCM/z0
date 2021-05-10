//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static CliRows;
    using static CliTableKinds;
    using static memory;
    using static Part;

    partial struct CliReader
    {
        public AssemblyRefRow Row(CliRowKey<AssemblyRef> key)
        {
            var dst = new AssemblyRefRow();
            var src = MD.GetAssemblyReference(Cli.handle<AssemblyReferenceHandle>(key));
            dst.Culture = src.Culture;
            dst.Flags = src.Flags;
            dst.Hash = src.HashValue;
            dst.Token = src.PublicKeyOrToken;
            dst.Version = src.Version;
            return dst;
        }
    }
}