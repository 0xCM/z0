//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial class WfShell
    {
        [Op]
        public static WfSettings settings(IWfContext context)
        {
            var dst = z.dict<string,string>();
            var assname = Assembly.GetEntryAssembly().GetSimpleName();
            var filename = FS.file(assname, FileExtensions.Json);
            var src = context.Paths.ConfigRoot + filename;
            JsonSettings.absorb(src, dst);
            return new WfSettings(dst);
        }
    }
}