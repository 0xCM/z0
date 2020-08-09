//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;    
    using static CaptureHostApiStep;

    [Step(Kind)]
    public readonly ref struct CaptureHostMembers
    {
        public WfState Wf {get;}
        
        readonly IPartCaptureArchive Target;

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public CaptureHostMembers(WfState state, IPartCaptureArchive dst, CorrelationToken ct)
        {
            Wf = state;
            Target = dst;
            Ct = ct;
            Wf.Created(Name, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(Name, Ct);
        }
                
        public void Execute(IApiHost host)
        {
            try
            {
                using var extract = new ExtractHostMembers(Wf, host, Target, Ct);
                extract.Run();

                using var emit = new EmitHostArtifacts(Wf, host.Uri, extract.Extractions, Target, Ct);
                emit.Run();            
            }
            catch(Exception e)
            {
                Wf.Error(Name,e, Ct);
            }
        }      
    }
}