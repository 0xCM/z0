//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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
}