//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Root;
    using static DiagnosticRecords;

    using ClrMd = Microsoft.Diagnostics.Runtime;

    public readonly partial struct DiagnosticProcessors
    {
        public class ModuleProcessor
        {
            readonly IEventSink Events;

            readonly bool Pll;

            readonly ConcurrentBag<ModuleInfo> Storage;

            readonly object Locker;

            [MethodImpl(Inline)]
            internal ModuleProcessor(IEventSink sink, bool pll = true)
            {
                Events = sink;
                Pll = pll;
                Storage = new();
                Locker = new();
            }

            public void Process(ReadOnlySpan<ClrMd.ClrModule> src)
            {
                root.iter(src, Process, Pll);
            }

            public void Process(ClrMd.ClrModule src)
            {
                var dst = new ModuleInfo();
                dst.Address = src.Address;
                dst.Name = FS.path(src.Name).FileName.Format();
                dst.AssemblyAddress = src.AssemblyAddress;
                dst.MetadataAddress = src.MetadataAddress;
                dst.MetadataSize = src.MetadataLength;
                dst.Layout = src.Layout;
                dst.ImageBase = src.ImageBase;
                dst.ModulePath = FS.path(src.Name).ToUri().Format();
                var pdb = src.Pdb;
                if(pdb != null)
                    dst.Pdb = new PdbInfo(pdb.Guid, pdb.Revision, FS.path(pdb.Path));
                else
                    dst.Pdb = PdbInfo.Empty;
                Storage.Add(dst);
            }

            public Index<ModuleInfo> Processed()
            {
                var data = Index<ModuleInfo>.Empty;
                lock(Locker)
                {
                    data = Storage.ToArray();
                    Storage.Clear();
                }
                return data;
            }
        }
    }
}