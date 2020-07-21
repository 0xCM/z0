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

    partial struct AccessorCapture
    {
        // public CapturedAccessor[] Capture(FilePath src, FilePath dst)        
        // {
        //     var assembly = Assembly.LoadFrom(src.Name);  
        //     return CaptureAsm(host, Resources.accessors(assembly), dst);
        // }

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