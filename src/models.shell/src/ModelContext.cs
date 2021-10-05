//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    sealed class ModelContext : ModelContext<ModelContext,IWfRuntime>
    {
        protected override void Initialize(IWfRuntime context)
        {
            Random = Rng.pcg64();
        }
    }
}