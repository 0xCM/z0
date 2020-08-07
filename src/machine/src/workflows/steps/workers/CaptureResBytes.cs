//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CaptureResBytesStep
    {
        public const string Worker = nameof(CaptureResBytes);
    }
    
    public readonly ref struct CaptureResBytes
    {
        readonly Recapture Workflow;

        readonly CorrelationToken Ct;
        
        [MethodImpl(Inline)]
        public CaptureResBytes(Recapture workflow, CorrelationToken ct)
        {
            Workflow = workflow;
            Ct = ct;
        }
        
        /// <summary>
        /// All of your resbytes belong to us
        /// </summary>
        public void Run()
        {            
            var resfile = z.insist(Workflow.ResBytesCompiled);
            var captured = Workflow.Capture(resfile, Workflow.ResBytesUncompiled);                        
            var csvfile = Workflow.ResIndexDir + FileName.Define("z0.res.bytes", FileExtensions.Csv);
            Workflow.SaveResIndex(captured, csvfile);
        }
    }
}