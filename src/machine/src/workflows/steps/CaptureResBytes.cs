//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly ref struct CaptureResBytes
    {
        readonly AsmRecapture Workflow;

        readonly CorrelationToken Ct;

        [MethodImpl(Inline)]
        public CaptureResBytes(AsmRecapture workflow, CorrelationToken ct)
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
            var csvfile = Workflow.ResIndexDir + FileName.define("z0.res.bytes", FileExtensions.Csv);
            Workflow.SaveIndex(captured, csvfile);
        }
    }
}