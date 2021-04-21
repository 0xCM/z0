//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XSvc
    {
        public static ImageMetaPipe ImageMetaPipe(this IWfRuntime wf)
            => Z0.ImageMetaPipe.create(wf);

        public static MsilPipe MsilPipe(this IWfRuntime wf)
            => Z0.MsilPipe.create(wf);

        public static ImageCsvReader ImageCsvReader(this IWfRuntime wf)
            => Z0.ImageCsvReader.create(wf);

    }
}