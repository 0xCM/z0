//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitPack)]

namespace Z0.Parts
{
    public sealed class BitPack : Part<BitPack>
    {
        public override IPartExecutor Executor
            => new BitPackExecutor();

    }

    public sealed partial class BitPackExecutor : PartExecutor<BitPackExecutor>
    {
        public override void Run()
        {

        }
    }

}