//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    public sealed class ResDataService : WfService<ResDataService,IResData>, IResData
    {
        public Index<ResEmission> EmitReferenceData()
            =>  ResEmitter.reference(Wf);

        public Index<DocLibEntry> EmitContentIndex()
            =>  ResEmitter.EmitContentIndex(Wf);

        public Index<ResEmission> EmitEmbedded(Assembly src, FS.FolderPath root, utf8 match, bool clear)
            => ResEmitter.embedded(Wf, src, root, match, clear);

        public ResEmission Emit(in ResDescriptor src, FS.FolderPath root)
            => ResEmitter.emit(src, root);
    }
}