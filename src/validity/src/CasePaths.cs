//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public readonly struct CasePaths
    {
        public PartId PartId {get;}

        public FS.FolderPath Root {get;}

        public Type UnitType {get;}

        [MethodImpl(Inline)]
        public CasePaths(FS.FolderPath root, PartId part, Type subject)
        {
            PartId = part;
            Root = root;
            UnitType = subject;
        }

        FS.FolderPath PartDir
        {
            [MethodImpl(Inline)]
            get => Root + FS.folder(PartId.Format());
        }

        FS.FolderPath CaseDir
        {
            [MethodImpl(Inline)]
            get => PartDir + FS.folder(UnitType.Name);
        }

        [MethodImpl(Inline)]
        public FS.FilePath CasePath(FS.FileName @case)
            => CaseDir + @case;

        [MethodImpl(Inline)]
        public FS.FilePath CasePath(FS.FileExt? ext = null, [Caller] string caller = null)
            => CasePath(FS.file(caller,  ext ?? DefaultExt));

        [MethodImpl(Inline)]
        public FS.FilePath CasePath(string @case, FS.FileExt? ext = null)
            => CasePath(FS.file(@case, ext ?? FileExtensions.Csv));

        FS.FileExt DefaultExt
        {
            [MethodImpl(Inline)]
            get => FileExtensions.Csv;
        }
    }
}