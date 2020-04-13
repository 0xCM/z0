//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        

    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Characterizes a contextual asm service where caller-managed lifecyle is not needed
    /// </summary>
    public interface IAsmService :  IService<IAsmContext>
    {
        IAppPaths AppPaths => Context.Paths;

        AsmEmissionPaths EmissionPaths => AsmEmissionPaths.Default;

        AsmEmissionPaths Emissions(FolderName area, FolderName subject) => EmissionPaths.Subject(area,subject);

        FolderPath EmissionRoot => EmissionPaths.EmissionRoot;
        
        IAppSettings Settings => Context.Settings;

        IApiSet ApiSet => Context.ApiSet;

        IApiHost[] Hosts => ApiSet.Hosts;
        
        IAppMsgSink Sink => Context;

        IAppMsgQueue Queue => Context;

        IPolyrand Random => Context.Random;

        IAsmFormatter Formatter => Context.AsmFormatter;

        IAsmFunctionDecoder Decoder => Context.AsmDecoder;

        IFunctionStreamWriter Writer(FilePath dst) => Context.AsmWriter(dst);

        void Notify(AppMsg msg) => Sink.Deposit(msg);
        
        void Notify(object content, AppMsgColor color = AppMsgColor.Green)
            => Context.NotifyConsole(content, color);
    }

    /// <summary>
    /// Characterizes contexutal asm service with caller-managed lifecycle
    /// </summary>
    public interface IAsmServiceAllocation : IAsmService, IServiceAllocation<IAsmContext>
    {

    }
}