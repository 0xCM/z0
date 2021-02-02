//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    public interface IResData : IWfService
    {
        Index<ResEmission> EmitReferenceData();

        Index<DocLibEntry> EmitContentIndex();

        Index<ResEmission> EmitEmbedded(Assembly src, FS.FolderPath root, utf8 match = default,  bool clear = true);

        ResEmission Emit(in ResDescriptor src, FS.FolderPath root);
    }
}