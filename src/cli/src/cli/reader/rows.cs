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

    partial struct CliReader
    {
        public AssemblyRefRow Row(AssemblyReferenceHandle handle)
        {
            var dst = new AssemblyRefRow();
            var src = MD.GetAssemblyReference(handle);
            dst.Culture = src.Culture;
            dst.Flags = src.Flags;
            dst.Hash = src.HashValue;
            dst.Token = src.PublicKeyOrToken;
            dst.Version = src.Version;
            dst.Name = src.Name;
            return dst;
        }

        public CliRows.AssemblyRefInfo Describe(AssemblyReferenceHandle handle)
        {
            var src = MD.GetAssemblyReference(handle);
            var dst = new CliRows.AssemblyRefInfo();
            var row = new AssemblyRefRow();
            dst.Token = Cli.token(handle);
            row.Culture = src.Culture;
            row.Flags = src.Flags;
            row.Hash = src.HashValue;
            row.Token = src.PublicKeyOrToken;
            row.Version = src.Version;
            row.Name = src.Name;
            dst.Row = row;
            dst.AssemblyName = src.GetAssemblyName();
            return dst;
        }
    }
}