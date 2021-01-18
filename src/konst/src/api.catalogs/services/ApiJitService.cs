//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Service(typeof(IApiJit))]
    public sealed class ApiJitService : WfService<ApiJitService,IApiJit>, IApiJit
    {

        public unsafe Index<ApiAddressRecord> JitApi(FS.FilePath dst)
        {
            var @base = Runtime.CurrentProcess.BaseAddress;
            var catalog = Wf.ApiParts.Api;
            var parts = catalog.Parts;
            var outer = Wf.Running($"Jitting {parts.Length} parts");
            var all = root.list<MethodAddress>();
            var total = 0u;
            foreach(var part in parts)
            {
                var members = ApiJit.jit(part);
                if(members.Count != 0)
                {
                    var flow = Wf.Running(Msg.Jitting.Format(part));
                    var addresses = members.Storage.Select(m => new MethodAddress(m.Method));
                    all.AddRange(addresses);
                    var memories = ApiPartMemories.load(part.Owner, addresses);
                    var first = memories.First;
                    var last = memories.Last;
                    var range = memories.Range;
                    var length = range.Length/1024;
                    if(length == 0)
                        length = 1;
                    total += length;

                    Wf.Ran(flow, Msg.Jitted.Format(members.Count, part, range, length));
                }
            }
            Wf.Ran(outer, string.Format("Jitted {0:#,#}mb member data", total));

            var sorted = Index.sort(all.ToArray());
            var records = root.mapi(sorted, (i,x) => ApiQuery.record((uint)i, x));
            var emission = Records.emit(records, new byte[]{12,16,16,32,80}, dst);
            Wf.Status(emission);

            return records;
        }
    }

    partial struct Msg
    {
        public static RenderPattern<IPart> Jitting => "Jitting {0}";

        public static RenderPattern<uint,IPart,MemoryRange,ByteSize> Jitted => "Jitted {0} {1} members that cover memory segment {2} of size {3}mb";
    }
}