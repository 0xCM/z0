//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm;

    using P = Z0.Parts;

    readonly struct SelectedParts : IIndex<IPart>
    {
        public static SelectedParts Selected 
            => default(SelectedParts);
        
        public static IPart[] Known
            => KnownParts.Service.Known.Where(r => r.Id != 0).ToArray();
        IPart[] IContented<IPart[]>.Content
            => new IPart[]{P.GMath.Resolved};
    }

    public interface ISuiteContext : IContext
    {
        IAsmContext AsmContext {get;}

        IAppContext ContextRoot 
            => AsmContext.ContextRoot;
        
        TAppPaths AppPaths 
            => ContextRoot.AppPaths;
    }
    
    public readonly struct ContextFactory
    {        
        public static IAppContext CreateAppContext()
            => AppContext.Create(AppPaths.Default, 
                            ApiComposition.Assemble(SelectedParts.Known), 
                            Polyrand.Pcg64(PolySeed64.Seed05));


        public static IAppContext CreateApiContext()
            => AppContext.Create(ApiComposition.Assemble(SelectedParts.Known), 
                    Polyrand.Pcg64(PolySeed64.Seed05), 
                        AppSettings.Load(AppPaths.Default.AppConfigPath), 
                        AppMsgExchange.Create());

        public static IAsmContext CreateAsmContext(IAppContext app)
            => AsmContext.Create(app);
        

        public static IAsmContext CreateAsmContext()
            => AsmContext.Create(CreateAppContext());
        
        public static ISuiteContext CreateSuiteContext()
            => new SuiteContext(CreateAsmContext(CreateAppContext()));

        public static ISuiteContext CreateSuiteContext(IAppContext app)
            => new SuiteContext(CreateAsmContext(app));

    }
    
    public readonly struct SuiteContext : ISuiteContext
    {
        public IAsmContext AsmContext {get;}

        public SuiteContext(IAsmContext asm)
        {
            AsmContext = asm;            
        }
    }
}