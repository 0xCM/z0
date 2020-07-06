//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct PartResolver : TPartResolver
    {
        public static IPartResolver Service => default(PartResolver);
    }
}