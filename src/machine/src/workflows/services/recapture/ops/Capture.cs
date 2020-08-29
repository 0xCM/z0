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
            SaveIndex(captured, csvfile);
        }

        public CapturedAccessor[] Capture(FilePath src, FolderPath dst)
        {
            var resdll = Assembly.LoadFrom(src.Name);
            var indices = span(Resources.declarations(resdll));
            var count = indices.Length;

            term.magenta($"Capturing {count} host resource sets from {src} -> {dst}");

            var results = list<CapturedAccessor>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var index = ref skip(indices,i);
                var host = Flow.uri(index.DeclaringType);
                var path = dst + host.FileName(FileExtensions.Asm);
                results.AddRange(Capture(host, index.Data, path));
            }

            var data = results.Array();
            term.print(new CapturedResourceSets(nameof(Recapture), data, src, dst));
            return data;
        }
    }
}