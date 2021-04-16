//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class ImageDataEmitter
    {
        public void ClearApiImageContent()
        {
            var dir = Db.TableDir<ImageContent>();
            var flow = Wf.Running($"Clearing content from <{dir}>");
            var dst = root.list<FS.FilePath>();
            dir.Clear(dst);
            Wf.Ran(flow, $"Cleared <{dst.Count}> files from <{dir}>");
        }

        public void EmitApiImageContent()
        {
            var flow = Wf.Running();
            var pipe = Wf.ProcessContextPipe();
            ClearApiImageContent();
            root.iter(Wf.Api.PartComponents, c => pipe.EmitImageContent(c));
            Wf.Ran(flow);
        }
    }
}