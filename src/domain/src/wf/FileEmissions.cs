//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct FileEmissions
    {
        [Op]
        public static FS.FilePath[] match(FS.FolderPath root, params FS.FileExt[] ext)
        {
            var files = FS.archive(root, ext).Files().Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static FS.FilePath[] match(FS.FolderPath root, uint max, params FS.FileExt[] ext)
        {
            var files = FS.archive(root, ext).Files().Take(max).Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static CmdResult exec(EmitFileListCmd cmd)
        {
            var archive = FS.archive(cmd.SourceDir, cmd.FileKinds);
            var id = Cmd.id(cmd);
            var list = cmd.EmissionLimit != 0 ? match(cmd.SourceDir, cmd.EmissionLimit, cmd.FileKinds) : match(cmd.SourceDir, cmd.FileKinds);
            var outcome = FileEmissions.emit(list, cmd.FileUriMode, cmd.TargetPath);
            return Cmd.result(id,outcome);
        }

        [Op]
        public static Outcome<FileEmission> emit(FS.FilePath[] src, bool uri, FS.FilePath dst)
        {
            var counter  = 0;
            try
            {
                var count = src.Length;
                using var writer = dst.Writer();
                foreach(var file in src)
                {
                    var line = uri ? file.ToUri().Format() : file.Format();
                    writer.WriteLine(line);
                    counter++;
                }

                return new FileEmission(dst, (int)counter);
            }
            catch(Exception e)
            {
                return e;
            }
        }
    }
}