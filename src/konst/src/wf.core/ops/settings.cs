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

    partial struct WfCore
    {
        [Op]
        public static WfSettings settings(IShellContext context)
        {
            FilePath configPath()
            {
                var assname = Assembly.GetEntryAssembly().GetSimpleName();
                var filename = FileName.define(assname, FileExtensions.Json);
                var src = context.Paths.ConfigRoot + filename;
                return src;
            }

            var dst = z.dict<string,string>();
            JsonSettings.absorb(configPath(),dst);
            return new WfSettings(dst);
        }

        [Op]
        public static WfSettings settings(IShellPaths paths)
        {
            var assname = Assembly.GetEntryAssembly().GetSimpleName();
            var filename = FileName.define(assname, FileExtensions.Json);
            var src = paths.ConfigRoot + filename;
            var dst = z.dict<string,string>();
            JsonSettings.absorb(src,dst);
            return new WfSettings(dst);
        }
    }
}