//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static z;

    public readonly struct MatchEmissions
    {
        public IWfCaptureContext Workflow {get;}

        readonly CorrelationToken Ct;

        public ICaptureContext Context
            => Workflow.Context;

        [MethodImpl(Inline)]
        public MatchEmissions(IWfCaptureContext workflow, CorrelationToken ct)
        {
            Workflow = workflow;
            Ct = ct;
        }

        TCheckEquatable Claim
            => CheckEquatable.Checker;

        public void Run(ApiHostUri host, ReadOnlySpan<ApiHex> srcA, FilePath srcB)
        {
            var wfStateless = Capture.Services;
            //var reader = wfStateless.HexReader;
            var reader = Archives.reader<ApiHexReader>();
            var fileSrc = @readonly(reader.Read(srcB));

            Claim.Eq(fileSrc.Length, srcA.Length);
            Claim.Eq(Spans.count<ApiHex>(fileSrc, s => s.OpUri.IsEmpty),0);
            for(var i=0; i<srcA.Length; i++)
            {
                Claim.Eq(skip(fileSrc,i).OpUri, skip(srcA,i).OpUri);
                Claim.Eq(skip(fileSrc,i).Encoded.Length, skip(srcA, i).Encoded.Length);
            }

            Context.Raise(new MatchedCapturedEmissions(host, srcA.Length, srcB));
        }
    }
}