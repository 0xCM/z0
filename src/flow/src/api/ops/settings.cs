//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

    partial struct OldFlow    
    {        
        [Op]
        public static WfSettings settings(IAppContext context, CorrelationToken ct)
        {

            FilePath configPath()
            {
                var assname = Assembly.GetEntryAssembly().GetSimpleName();
                var filename = FileName.Define(assname, FileExtensions.Json);
                var src = context.AppPaths.ConfigRoot + filename;
                return src;
            }        

            var path = configPath();
            Flow.termsink(ct).Deposit(new LoadingWfConfig(nameof(OldFlow), path, ct));

            var dst = z.dict<string,string>();
            AppSettings.absorb(path,dst);
            var config = new WfSettings(dst);
                        
            Flow.termsink(ct).Deposit(new LoadedWfConfig(nameof(OldFlow), path, config, ct));            
            return config;
        }        
    }
}