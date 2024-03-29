//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static SdmModels;

    partial class IntelSdm
    {
        public ReadOnlySpan<UnicodeLine> LoadImportedVolume(VolDigit digit)
        {
            var path = SdmPaths.SdmDstPath((byte)digit);
            if(!path.Exists)
            {
                Error(FS.missing(path));
                return default;
            }

            var flow = Running(string.Format("Reading {0}", path.ToUri()));
            var stats = path.FileStats();
            var dst = span<UnicodeLine>(stats.LineCount);
            var counter = 0u;
            using var reader = path.UnicodeLineReader();
            while(reader.Next(out var line))
                seek(dst, counter++) = line;
            Ran(flow, string.Format("Read {0} lines from {1}", counter, path.ToUri()));
            return dst;
        }
    }
}