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
            =>  ResData.reference(Wf);

        public Index<DocLibEntry> EmitContentIndex()
            =>  ResData.EmitContentIndex(Wf);

        public Index<ResEmission> EmitEmbedded(Assembly src, FS.FolderPath root, utf8 match, bool clear)
            => ResData.embedded(Wf, src, root, match, clear);

        public ResEmission Emit(in ResDescriptor src, FS.FolderPath root)
            => ResData.emit(src, root);
    }
}