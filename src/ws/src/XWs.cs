//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public static class XWs
    {
       [Op]
       public static DevWs DevWs(this IEnvProvider provider)
            => Z0.DevWs.create(provider.Env.DevWs);
    }
}