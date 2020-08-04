//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static z;

    partial struct Recapture
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
                
        public CapturedAccessor[] Capture(FilePath respath, FolderPath asmdir)        
        {
            var resdll = Assembly.LoadFrom(respath.Name);  
            var indices = span(Resources.declarations(resdll));
            var idxcount = indices.Length;

            term.magenta($"Capturing {idxcount} host resource sets from {respath} -> {asmdir}");

            var results = list<CapturedAccessor>();
            for(var i=0u; i<idxcount; i++)
            {
                ref readonly var index = ref skip(indices,i);            
                var host = InferHostUri(index.DeclaringType);                
                var asmpath = asmdir + host.FileName(FileExtensions.Asm);
                var captured = CaptureAsm(host, index.Data, asmpath);
                results.AddRange(captured);
            }

            term.magenta($"Captured {results.Count} {respath.FileName} acessors");

            return results.Array();
        }        
    }
}