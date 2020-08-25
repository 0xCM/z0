//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    public readonly struct ToolProxies
    {
        public static string[] create(ToolProxy config)
        {
            var compilation = ToolProxyGen.compilation(config);
            var dst = config.TargetPath.CreateParentIfMissing();

            using (var exe = new FileStream(dst.Name, FileMode.Create))
            using (var resources = compilation.CreateDefaultWin32Resources(true, true, null, null))
            {
                var result = compilation.Emit(exe, win32Resources: resources);

                if (!result.Success)
                    return result.Diagnostics.Map(x => x.ToString()).Array();
            }

            return default;
        }
    }
}