//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    using P = Z0.Parts;
    
    [ApiHost]
    public readonly struct ContextFactory
    {        
        [MethodImpl(Inline),Op]
        public static IAsmContext CreateAsmContext(IAppContext app)
            => AsmContext.Create(app);

        [MethodImpl(Inline),Op]
        public static IWfCapture WfCapture(WfContext wf, CorrelationToken? ct = null)
            => new WfCapture(CreateAsmContext(wf.ContextRoot), ct);

        public static IAppContext CreateAppContext()
            => AppContext.Create(AppPaths.Default, 
                            ApiComposition.Assemble(SelectedParts.Known), 
                            Polyrand.Pcg64(PolySeed64.Seed05));

        public static IAppContext CreateApiContext()
            => Apps.context(ApiComposition.Assemble(SelectedParts.Known), 
                    Polyrand.Pcg64(PolySeed64.Seed05), 
                        AppSettings.Load(AppPaths.Default.AppConfigPath), 
                        AppMsgExchange.Create());
        
        public static IAsmContext CreateAsmContext()
            => AsmContext.Create(CreateAppContext());
        
        public static IWfCapture CreateClientContext()
            => new WfCapture(CreateAsmContext(CreateAppContext()));
    }

    readonly struct SelectedParts : IContentedIndex<IPart>
    {
        public static SelectedParts Selected 
            => default;
        
        public static IPart[] Known
            => KnownParts.Service.Known.Where(r => r.Id != 0).ToArray();
        
        IPart[] IContented<IPart[]>.Content
            => new IPart[]{P.GMath.Resolved};
    }
}