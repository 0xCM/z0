//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Blittable)]

namespace Z0.Parts
{
    public sealed class Blittable : Part<Blittable>
    {
        public override IPartExecutor Executor
            => new BlittableExecutor();
    }

    public sealed partial class BlittableExecutor : PartExecutor<BlittableExecutor>
    {
        public override void Run()
        {

        }
    }
}