//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    using static IntelSdm;

    partial class IntelSdmProcessor
    {
        public ReadOnlySpan<UnicodeLine> ReadLinedVolume(VolDigit digit)
        {
            var path = LinedSdmPath((byte)digit);
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