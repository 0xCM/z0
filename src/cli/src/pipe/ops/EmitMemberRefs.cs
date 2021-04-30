//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;
    using static memory;
    using static Images;

    partial class ImageMetaPipe
    {
        public void EmitMemberRefs()
        {
            var components = Wf.ApiCatalog.Components.View;
            var count = components.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                var component = skip(components,i);
                var dst = MemberRefsPath(component);
                var flow = Wf.EmittingTable<MemberRefRow>(dst);
                using var reader = ImageMetadata.reader(FS.path(component.Location));
                var emitted = Tables.emit(reader.ReadMemberRefs(), dst);
                Wf.EmittedTable(flow,emitted);
                counter += emitted;
            }
        }
    }
}