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
       public static AsmWorkspace AsmWs(this IEnvProvider provider)
            => Z0.AsmWorkspace.create(provider.Env.AsmWs);

       [Op]
       public static Workspaces DevWs(this IEnvProvider provider)
            => Z0.Workspaces.dev(provider);
    }
}