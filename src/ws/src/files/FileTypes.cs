//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Blit;
    using static FileKindNames;

    [ApiHost]
    public class FileTypes
    {
        [MethodImpl(Inline)]
        public static TypedFile<K> file<K>(FS.FilePath src)
            where K : struct, IFileType<K>
                => new TypedFile<K>(src);

        [MethodImpl(Inline), Op]
        public static TypedFile file(FileType type, FS.FilePath path)
            => new TypedFile(type,path);

        [MethodImpl(Inline), Op]
        public static FileType define(FileKind kind, text15 ext)
            => new FileType(kind,ext);

        public static FileKind classify(FS.FilePath src)
            => default;

        public static FileType Csv
        {
            [MethodImpl(Inline), Op]
            get => define(FileKind.Csv, csv);
        }

        public static FileType Asm
        {
            [MethodImpl(Inline), Op]
            get => define(FileKind.Asm, asm);
        }

        public static FileType ObjAsm
        {
            [MethodImpl(Inline), Op]
            get => define(FileKind.ObjAsm, objasm);
        }

        public static FileType ObjYaml
        {
            [MethodImpl(Inline), Op]
            get => define(FileKind.ObjYaml, objyaml);
        }

        public static FileType YamlTok
        {
            [MethodImpl(Inline), Op]
            get => define(FileKind.YamlTok, yamltok);
        }

        public static FileType McOpsAsm
        {
            [MethodImpl(Inline), Op]
            get => define(FileKind.McOpsAsm, mcopsasm);
        }

        public static FileType McOpsLog
        {
            [MethodImpl(Inline), Op]
            get => define(FileKind.McOpsLog, mcopslog);
        }

        public static FileType Sym
        {
            [MethodImpl(Inline), Op]
            get => define(FileKind.Sym, sym);
        }

        public static FileType CoffHeaders
        {
            [MethodImpl(Inline), Op]
            get => define(FileKind.CoffHeaders, coffheaders);
        }
    }
}