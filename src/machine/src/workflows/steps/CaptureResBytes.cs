//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AccessorCapture
    {
        /// <summary>
        /// All of your resbytes belong to us
        /// </summary>
        public void CaptureResBytes()
        {            
            var resfile = z.insist(ResBytesCompiled);
            var captured = Capture(resfile, ResBytesUncompiled);                        
            var csvfile = ResIndexDir + FileName.Define("z0.res.bytes", FileExtensions.Csv);
            SaveResIndex(captured, csvfile);
        }
    }

    public readonly ref struct CaptureResBytes
    {
        readonly AccessorCapture Workflow;

        [MethodImpl(Inline)]
        public CaptureResBytes(AccessorCapture workflow)
        {
            Workflow = workflow;
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