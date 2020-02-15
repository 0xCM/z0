//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public static class AsmPaths
    {
        public static FilePath HexFilePath(this AssemblyId origin, string host, OpIdentity id)
            => Paths.AsmDataDir(RelativeLocation.Define(origin.Format(), host)) + Paths.AsmHexFile(id);

        public static FilePath RawFilePath(this AssemblyId origin, string host, OpIdentity id)
            => Paths.AsmDataDir(RelativeLocation.Define(origin.Format(), host)) + Paths.AsmRawFile(id);

        public static FilePath AsmFilePath(this AssemblyId origin, string host, OpIdentity id)
            => Paths.AsmDataDir(RelativeLocation.Define(origin.Format(), host)) + Paths.AsmDetailFile(id);

        public static FilePath CilFilePath(this AssemblyId catalog, string host, OpIdentity id)
            => Paths.AsmDataDir(RelativeLocation.Define(catalog.Format(), host)) + Paths.CilFile(id);

        public static FilePath HexFilePath(this ApiHostPath host, OpIdentity id)
            => Paths.AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + Paths.AsmHexFile(id);

        public static FilePath RawFilePath(this ApiHostPath host, OpIdentity id)
            => Paths.AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + Paths.AsmRawFile(id);

        public static FilePath AsmFilePath(this ApiHostPath host, OpIdentity id)
            => Paths.AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + Paths.AsmDetailFile(id);

        public static FilePath CilFilePath(this ApiHostPath host, OpIdentity id)
            => Paths.AsmDataDir(RelativeLocation.Define(host.Owner.Format(), host.Name)) + Paths.CilFile(id);

        public static FilePath ArchivePath(this ArchiveFileKind kind, AssemblyId origin, string host, OpIdentity id)
            => kind switch {
                ArchiveFileKind.Hex  => origin.HexFilePath(host, id),
                ArchiveFileKind.Raw  => origin.RawFilePath(host, id),
                ArchiveFileKind.Asm  => origin.AsmFilePath(host, id),
                ArchiveFileKind.Cil  => origin.CilFilePath(host, id),
                _  => FilePath.Empty,
            };

        public static FilePath ArchivePath(this ArchiveFileKind kind, ApiHostPath host, OpIdentity id)
            => kind switch {
                ArchiveFileKind.Hex  => host.HexFilePath(id),
                ArchiveFileKind.Raw  => host.RawFilePath(id),
                ArchiveFileKind.Asm  => host.AsmFilePath(id),
                ArchiveFileKind.Cil  => host.CilFilePath(id),
                _  => FilePath.Empty,
            };

    }
}