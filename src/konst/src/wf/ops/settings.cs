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

    partial struct Flow
    {
        [Op]
        public static WfSettings settings(IShellContext context)
        {
            FilePath configPath()
            {
                var assname = Assembly.GetEntryAssembly().GetSimpleName();
                var filename = FileName.define(assname, FileExtensions.Json);
                var src = context.AppPaths.ConfigRoot + filename;
                return src;
            }

            var dst = z.dict<string,string>();
            SettingValues.absorb(configPath(),dst);
            return new WfSettings(dst);
        }

        [Op]
        public static WfSettings settings(IShellPaths paths)
        {
            var assname = Assembly.GetEntryAssembly().GetSimpleName();
            var filename = FileName.define(assname, FileExtensions.Json);
            var src = paths.ConfigRoot + filename;
            var dst = z.dict<string,string>();
            SettingValues.absorb(src,dst);
            return new WfSettings(dst);
        }
    }
}