//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public struct ProcessContext
    {
        public int ProcessId;

        public string ProcessName;

        public Identifier Subject;

        public Timestamp Timestamp;

        public Index<ProcessImageRow> Summaries;

        public FS.FilePath SummaryPath;

        public Index<MemoryRegion> Details;

        public FS.FilePath DetailPath;

        public FS.FilePath DumpPath;
    }
}