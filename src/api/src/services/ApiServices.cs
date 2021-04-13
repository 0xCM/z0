//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static memory;
    using static Sequential;

    public sealed class ApiServices : WfService<ApiServices>
    {
        ApiCatalogs Catalogs;

        protected override void OnInit()
        {
            Catalogs = Wf.ApiCatalogs();
        }

        public Index<DataType> DataTypes()
            => Z0.DataTypes.search(Wf.Components);

        public ApiMembers JitCatalog()
            => Wf.ApiJit().JitCatalog();

        public BasedApiMemberCatalog RebaseMembers(Timestamp? ts = null)
            => RebaseMembers(JitCatalog(), ts);

        public BasedApiMemberCatalog RebaseMembers(ApiMembers src, Timestamp? ts = null)
        {
            var dst = Db.IndexTable<ApiCatalogEntry>((ts ?? root.timestamp()).Format());
            var flow = Wf.EmittingTable<ApiCatalogEntry>(dst);
            var records = CreateCatalogEntries(src.BaseAddress, src.View);
            var count = Tables.emit<ApiCatalogEntry>(records, dst, 16);
            Wf.EmittedTable<ApiCatalogEntry>(flow, count, dst);
            return new BasedApiMemberCatalog(dst, src, records);
        }

        public ApiMemberBlocks Correlate()
            => Correlate(Wf.Api.PartCatalogs());

        public ApiMemberBlocks Correlate(Index<IApiPartCatalog> src)
        {
            var flow = Wf.Running(Msg.CorrelatingParts.Format(src.Count));
            var hex = Wf.ApiHex();
            var count = src.Length;
            var dst = root.list<ApiMemberCode>();
            var records = root.list<ApiCorrelationEntry>();
            for(var i=0; i<count; i++)
            {
                var part = src[i];
                var inner = Wf.Running(Msg.CorrelatingOperations.Format(part.PartId.Format()));
                var hosts = part.ApiHosts.View;
                var kHost = hosts.Length;
                for(var j=0; j<kHost; j++)
                {
                    ref readonly var host = ref skip(hosts,j);
                    var hexpath = Db.ApiHexPath(host.Uri);
                    if(hexpath.Exists)
                    {
                        var blocks = hex.ReadBlocks(hexpath);
                        var catalog = Catalogs.HostCatalog(Wf.Api.FindHost(host.Uri).Require());
                        Correlate(catalog, blocks, dst, records);
                    }
                }
                Wf.Ran(inner);
            }

            var path = Db.IndexTable<ApiCorrelationEntry>();
            var emitting = Wf.EmittingTable<ApiCorrelationEntry>(path);
            var output = @readonly(records.OrderBy(x => x.RuntimeAddress).Array());
            Tables.emit(output, path);
            Wf.EmittedTable(emitting, output.Length);

            Wf.Ran(flow);
            return dst.ToArray();
        }

        int Correlate(ApiHostCatalog src, Index<ApiCodeBlock> blocks, List<ApiMemberCode> dst, List<ApiCorrelationEntry> records)
        {
            var part = src.Host.PartId;
            var members = src.Members.OrderBy(x => x.Id).Array();
            var targets = blocks.Where(x => x.IsNonEmpty && x.OpId.IsNonEmpty).OrderBy(x => x.OpId).Array();
            var correlated = (
                from m in members
                join t in targets on m.Id equals t.OpId orderby m.Id
                select root.paired(m, t)).Array();

            var count = correlated.Length;
            if(count > 0)
            {
                var view = @readonly(correlated);
                var seq = Sequential.create(0, (ushort)(part));
                for(var i=0u; i<count; i++)
                {
                    ref readonly var pair = ref skip(view,i);
                    fill(seq++, pair.Left, pair.Right, out var record);
                    records.Add(record);
                    dst.Add(new ApiMemberCode(pair.Left, pair.Right, i));
                }
            }
            return count;
        }

        static ref ApiCorrelationEntry fill(Seq16x2 seq, ApiMember member, ApiCodeBlock code, out ApiCorrelationEntry dst)
        {
            dst.Sequence = seq;
            dst.CaptureAddress = code.BaseAddress;
            dst.RuntimeAddress = member.BaseAddress;
            dst.Id = code.OpUri;
            return ref dst;
        }

        [Op]
        Index<ApiCatalogEntry> CreateCatalogEntries(MemoryAddress @base, ReadOnlySpan<ApiMember> members)
        {
            var count = members.Length;
            var buffer = alloc<ApiCatalogEntry>(count);
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
                record.MemberRebase = (uint)(member.BaseAddress - rebase);
                record.MaxSize = seq < count - 1 ? (ulong)(skip(members, seq + 1).BaseAddress - record.MemberBase) : 0ul;
                record.HostName = member.Host.Name;
                record.PartName = member.Host.Part.Format();
                record.OpUri = member.OpUri;
            }
            return buffer;
        }
    }
}