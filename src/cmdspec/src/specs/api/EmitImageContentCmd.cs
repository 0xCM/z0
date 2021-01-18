//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Linq;

    using static Konst;
    using static z;

    [Cmd(CmdName)]
    public struct EmitImageContentCmd : ICmd<EmitImageContentCmd>
    {
        public const string CmdName ="emit-image-content";

        public LocatedImage Source;

        public FS.FilePath Target;
    }

    partial class XCmd
    {

        public static EmitImageContentCmd EmitImageContent(this CmdBuilder builder, LocatedImage src)
            => define(builder.Wf, src);

        [Op]
        public static EmitImageContentCmd EmitImageContent(this CmdBuilder builder)
        {
            var dst = new EmitImageContentCmd();
            dst.Source = ImageMaps.main();
            dst.Target = builder.Db.Table(ImageContent.TableId, dst.Source.ImagePath.FileName.WithoutExtension);
            return dst;
        }

        public static void EmitImageContent(this CmdBuilder builder, Process src, out Index<EmitImageContentCmd> buffer)
            => specify(builder.Wf, src, out buffer);

        static ReadOnlySpan<ProcessModule> modules(Process src)
            => src.Modules.Cast<ProcessModule>().Array();

        [Op]
        static ref EmitImageContentCmd specify(IWfShell wf, ProcessModule src, ref EmitImageContentCmd cmd)
        {
            var located = ImageMaps.locate(src);
            cmd.Source = located;
            cmd.Target = wf.Db().Table(ImageContent.TableId, located.ImagePath.FileName.WithoutExtension);
            return ref cmd;
        }

        [Op]
        static void specify(IWfShell wf, Process src, out Index<EmitImageContentCmd> buffer)
        {
            var pmods = modules(src);
            var count = pmods.Length;
            buffer = sys.alloc<EmitImageContentCmd>(count);
            var dst = buffer.Edit;
            for(var i=0; i <count; i++)
                specify(wf, skip(pmods,i) , ref seek(dst,i));
        }

        [MethodImpl(Inline)]
        static EmitImageContentCmd define(LocatedImage src, FS.FilePath dst)
        {
            var cmd = new EmitImageContentCmd();
            cmd.Source = src;
            cmd.Target = dst;
            return cmd;
        }

        [MethodImpl(Inline)]
        static EmitImageContentCmd define(IWfShell wf, LocatedImage src)
            => define(src, wf.Db().Table(ImageContent.TableId, src.ImagePath.FileName.WithoutExtension));
    }
}