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

    using Z0.Images;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct ProcessImages
    {
        public static ReadOnlySpan<ProcessModule> modules(Process src)
            => src.Modules.Cast<ProcessModule>().Array();

        public static void EmitContent(IWfShell wf)
        {
            ProcessImages.specify(wf, Process.GetCurrentProcess(), out Index<EmitImageContentCmd> commands);
            iter(commands, cmd => Dispatch(wf, cmd));
        }

        public static void Dispatch(IWfShell wf, ICmdSpec cmd)
        {
            wf.Router.Dispatch(cmd);
        }

        [Op]
        public static ref EmitImageContentCmd specify(IWfShell wf, ProcessModule src, ref EmitImageContentCmd cmd)
        {
            var located = LocatedImages.locate(src);
            cmd.Source = located;
            cmd.Target = wf.Db().Table(ImageContentRecord.TableId, located.ImagePath.FileName.WithoutExtension);
            return ref cmd;
        }

        [Op]
        public static void specify(IWfShell wf, Process src, out Index<EmitImageContentCmd> buffer)
        {
            var pmods = modules(src);
            var count = pmods.Length;
            buffer = sys.alloc<EmitImageContentCmd>(count);
            var dst = buffer.Edit;
            for(var i=0; i <count; i++)
                specify(wf, skip(pmods,i) , ref seek(dst,i));
        }

        [MethodImpl(Inline)]
        public static EmitImageContentCmd define(LocatedImage src, FS.FilePath dst)
        {
            var cmd = new EmitImageContentCmd();
            cmd.Source = src;
            cmd.Target = dst;
            return cmd;
        }

        [MethodImpl(Inline)]
        public static EmitImageContentCmd define(IWfShell wf, LocatedImage src)
            => define(src, wf.Db().Table(ImageContentRecord.TableId, src.ImagePath.FileName.WithoutExtension));
    }
}