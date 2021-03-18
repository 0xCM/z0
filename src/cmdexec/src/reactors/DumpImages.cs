//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class DumpImages : CmdReactor<DumpImagesCmd>
    {
        protected override CmdResult Run(DumpImagesCmd cmd)
        {
            using var mapped = MemoryFiles.map(cmd.Source);
            var info = mapped.Descriptions;
            var count = info.Count;
            root.iter(info, file => Wf.Row(format(file)));
            for(ushort i=0; i<count; i++)
            {
                ref readonly var file = ref mapped[i];
                var target = cmd.Target + FS.file(file.Path.FileName.Name, FS.Extensions.Csv);
                var flow = Wf.EmittingFile(target);
                var service = MemoryEmitter.create(Wf);
                service.Emit(file.BaseAddress, file.Size, target);
                Wf.EmittedFile(flow,1);
            }

            return default;
        }

        static string format(MemoryFileInfo file)
            => string.Format("{0} | {1} | {2,-16} | {3}", file.BaseAddress, file.EndAddress, file.Size, file.Path.ToUri());
    }
}