//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct Apps
    {
        public static IWfRuntime runtime(string[] args)
            => WfRuntime.create(ApiParts.load(core.controller(), args), args).WithSource(Rng.@default());
    }
}