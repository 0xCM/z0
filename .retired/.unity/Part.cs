//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

[assembly: PartId(PartId.Unity)]

namespace Z0.Parts
{
    public sealed class Unity : Part<Unity>
    {
        public override PartId[] Needs
            => parts(PartId.Konst);
    }
}
