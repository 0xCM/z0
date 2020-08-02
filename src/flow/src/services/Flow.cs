//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    [ApiHost]
    public readonly partial struct Flow
    {
        public const string IdMarker = "{0} | ";

        public static string AppName 
        {
            [MethodImpl(Inline), Op]
            get => Assembly.GetEntryAssembly().GetSimpleName();
        }
        
        public static FilePath ConfigPath(IAppContext context)
        {
            var assname = Assembly.GetEntryAssembly().GetSimpleName();
            var filename = FileName.Define(assname, FileExtensions.Json);
            var src = context.AppPaths.ConfigRoot + filename;
            return src;
        }
    }
}