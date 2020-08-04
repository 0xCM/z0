//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Step(WfStepId.EmitContentCatalog, true)]
    public readonly struct EmitContentCatalogStep
    {
        public const string WorkerName = nameof(EmitContentCatalog);

        public const string DatasetName = "ContentCatalog";
    }
}