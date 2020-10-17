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

    partial struct WfShell
    {
        [MethodImpl(Inline), Op]
        public static IJsonSettings json(IWfPaths paths)
            => JsonSettings.Load(paths.AppConfigPath);

        [Op]
        public static WfSettings settings(IWfContext context)
        {
            var dst = z.dict<string,string>();
            JsonSettings.absorb(jsonPath(context),dst);
            return new WfSettings(dst);
        }

        [Op]
        static FilePath jsonPath(IWfContext context)
        {
            var assname = Assembly.GetEntryAssembly().GetSimpleName();
            var filename = FileName.define(assname, FileExtensions.Json);
            var src = context.Paths.ConfigRoot + filename;
            return src;
        }

        [Op]
        static WfSettings settings(IWfPaths paths)
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