//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static memory;

    [Service(typeof(IApiJit))]
    public sealed class ApiJitService : WfService<ApiJitService,IApiJit>, IApiJit
    {
        public BasedApiMembers JitApi(FS.FilePath dst)
        {
            var members = JitApi();
            EmitAddresses(members, dst);
            return members;
        }

        public BasedApiMembers JitApi()
        {
            var @base = Runtime.CurrentProcess.BaseAddress;
            var catalog = Wf.ApiParts.Api;
            var parts = catalog.Parts;
            var kParts = parts.Length;
            var flow = Wf.Running(Msg.JittingParts.Format(kParts));
            var all = root.list<ApiMembers>();
            var total = 0u;
            foreach(var part in parts)
            {
                var subflow = Wf.Running(Msg.JittingPart.Format(part.Id));
                var partMembers = ApiJit.jit(part);
                all.Add(partMembers);
                Wf.Ran(subflow, Msg.JittedPart.Format(partMembers.Length, part.Id));
            }

            var members = new BasedApiMembers(@base, all.SelectMany(x => x).OrderBy(x => x.BaseAddress).Array());
            Wf.Ran(flow, Msg.JittedMembers.Format(members.MemberCount, parts.Length));
            return members;
        }

        public Index<ApiAddressRecord> EmitAddresses(BasedApiMembers src, FS.FilePath dst)
        {
            var summaries = summarize(src.Base, src.Members.View);
            var emitting = Wf.EmittingTable<ApiAddressRecord>(dst);
            var emitted = Records.emit<ApiAddressRecord>(summaries, dst);
            Wf.EmittedTable<ApiAddressRecord>(emitting, emitted.RowCount, dst);
            return summaries;
        }

        static Index<ApiAddressRecord> summarize(MemoryAddress @base, ReadOnlySpan<ApiMember> members)
        {
            var count = members.Length;
            var buffer = alloc<ApiAddressRecord>(count);
            ref var dst = ref first(buffer);
            var rebase = first(members).BaseAddress;
            for(uint seq=0; seq<count; seq++)
            {
                ref var record = ref seek(dst,seq);
                ref readonly var member = ref skip(members, seq);
                record.Sequence = seq;
                record.ProcessBase = @base;
                record.MemberBase = member.BaseAddress;
                record.MemberOffset = member.BaseAddress - @base;
                record.MemberRebase = member.BaseAddress - rebase;
                record.MaxSize = seq < count - 1 ? (ulong)(skip(members, seq + 1).BaseAddress - record.MemberBase) : 0ul;
                record.HostName = member.Host.Name;
                record.PartName = member.Host.Owner.Format();
                record.Identifier = member.Id;
            }
            return buffer;
        }
    }

    partial struct Msg
    {
        public static RenderPattern<int> JittingParts => "Jitting {0} parts";

        public static RenderPattern<PartId> JittingPart => "Jitting {0} members";

        public static RenderPattern<int,PartId> JittedPart => "Jitting {0} {1} members";

        public static RenderPattern<dynamic,dynamic> JittedMembers => "Jitted {0} members from {1} parts";
    }
}