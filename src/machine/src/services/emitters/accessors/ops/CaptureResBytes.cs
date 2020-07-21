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
            var csvfile = ResBytesDir + resfile.FileName.ChangeExtension(FileExtensions.Csv);            
            SaveCatalog(captured, csvfile);
        }
    }
}