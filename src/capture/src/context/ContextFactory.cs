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
        public static IAppContext app()
            => AppContext.Create(AppPaths.Default, 
                            ApiComposition.Assemble(SelectedParts.Known), 
                            Polyrand.Pcg64(PolySeed64.Seed05));

        [MethodImpl(Inline),Op]
        public static IAsmContext asm(IAppContext app)
            => AsmContext.create(app);

        [MethodImpl(Inline),Op]
        public static IWfCapture wf(WfContext wf, CorrelationToken ct)
            => new WfCapture(asm(wf.ContextRoot), ct);
    }

    readonly struct SelectedParts : IContentedIndex<IPart>
    {        
        public static IPart[] Known
            => KnownParts.Service.Known.Where(r => r.Id != 0).ToArray();
        
        IPart[] IContented<IPart[]>.Content
            => new IPart[]{P.GMath.Resolved};
    }
}