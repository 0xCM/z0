//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static memory;
    using static Part;
    using static TextRules;
    using static Sequential;

    partial struct Msg
    {
        public static MsgPattern<Count> CorrelatingParts => "Correlating {0} part catalogs";

        public static MsgPattern<string> CorrelatingOperations => "Correlating {0} operations";
    }

    public sealed class ApiServices : WfService<ApiServices>
    {
        public IApiJit ApiJit {get; private set;}

        public IApiHexIndexer HexIndexer()
            => ApiHexIndexer.create(Wf);

        public ApiMemberBlocks Correlate()
            => Correlate(Wf.Api.PartCatalogs());

        /// <summary>
        /// Returns a <see cref='ApiHostCatalog'/> for a specified host
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="src">The host type</param>
        public ApiHostCatalog HostCatalog(Type src)
            => HostCatalog(ApiCatalogs.ApiHost(src));

        /// <summary>
        /// Returns a <see cref='ApiHostCatalog'/> for a specified host
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="src">The host type</param>
        [Op]
        public ApiHostCatalog HostCatalog(IApiHost src)
        {
            var flow = Wf.Running(Msg.CreatingHostCatalog.Format(src.Uri));
            var members = ApiJit.Jit(src);
            var result = members.Length == 0 ? ApiHostCatalog.Empty : new ApiHostCatalog(src, members.Sort());
            Wf.Ran(flow, Msg.CreatedHostCatalog.Format(src.Uri, members.Count));
            return result;
        }

        public ApiMemberBlocks Correlate(Index<IApiPartCatalog> src)
        {
            var flow = Wf.Running(Msg.CorrelatingParts.Format(src.Count));
            var reader = ApiHex.reader(Wf);
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
                    var hexpath = Db.ApiHexFile(host.Uri);
                    if(hexpath.Exists)
                    {
                        var blocks = reader.Read(hexpath);
                        var catalog = HostCatalog(Wf.Api.FindHost(host.Uri).Require());
                        Correlate(catalog, blocks, dst, records);
                    }
                }
                Wf.Ran(inner);
            }

            var path = Db.IndexTable<ApiCorrelationEntry>();
            var emitting = Wf.EmittingTable<ApiCorrelationEntry>(path);
            var output = @readonly(records.OrderBy(x => x.RuntimeAddress).Array());
            Records.emit(output, path);
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
            dst.Id = code.Uri;
            return ref dst;
        }


        protected override void OnInit()
        {
            ApiJit = Z0.ApiJit.create(Wf);
        }

        public Index<DataType> DataTypes()
            => Z0.DataTypes.search(Wf.Components);

        public BasedApiMemberCatalog RebaseMembers()
        {
            var members = ApiJit.JitApi();
            return RebaseMembers(members);
        }

        public BasedApiMemberCatalog RebaseMembers(BasedApiMembers src)
        {
            var dst = Db.IndexTable<ApiCatalogRecord>(root.timestamp().Format());
            var flow = Wf.EmittingTable<ApiCatalogRecord>(dst);
            var records = CatalogRecords(src.Base, src.Members.View);
            var count = Records.emit<ApiCatalogRecord>(records, dst, 16);
            Wf.EmittedTable<ApiCatalogRecord>(flow, count, dst);
            return new BasedApiMemberCatalog(dst, src, records);
        }

        public void EmitApiClasses()
        {
            var dst = Db.IndexTable("api.classes");
            var flow = Wf.EmittingTable<SymbolicLiteral>(dst);
            var service = ApiCatalogs.classes(Wf);
            var formatter = Records.formatter<SymbolicLiteral>();
            var classifiers = service.Classifiers();
            var literals = classifiers.SelectMany(x => x.Literals);
            var count = Records.emit(literals, dst);
            Wf.EmittedTable(flow, count);
        }

        public void EmitSymbolicLiterals()
        {
            var target = Db.IndexTable(SymbolicLiteral.TableId);
            var components = Wf.Components;
            EmitSymbolicLiterals(Wf.Components, target);
        }

        public Index<SymbolicLiteral> EmitSymbolicLiterals(Index<Assembly> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<SymbolicLiteral>(dst);
            var rows = Clr.enums(src).Sort();
            var kRows = rows.Length;
            using var writer = dst.Writer();
            var formatter = Records.formatter<SymbolicLiteral>(16);
            writer.WriteLine(formatter.FormatHeader());

            for(var i=0; i<kRows; i++)
                writer.WriteLine(formatter.Format(rows[i]));

            Wf.EmittedTable<SymbolicLiteral>(flow, rows.Length);
            return rows;
        }

        public Index<SymbolicLiteral> LoadSymbolicLiterals(TextDoc src)
        {
            var rc = src.RowCount;
            var dst = alloc<SymbolicLiteral>(rc);
            var parser = HexByteParser.Service;
            for(var i=0; i<rc; i++)
            {
                ref readonly var row = ref src[i];
                if(row.CellCount >= 3)
                {
                    var data = row[2];
                    var result = parser.ParseData(data);
                    if(result.Succeeded)
                    {
                        var bytes = span(result.Value);
                        var storage = 0ul;
                        ref var store = ref @as<ulong,byte>(storage);
                        var count = root.min(bytes.Length,8);
                        for(var j=0u; j<count; j++)
                            seek(store,j) = skip(bytes,j);

                        dst[i] = default;
                    }
                }
                else
                    dst[i] = default;
            }
            return dst;
        }

        [Op]
        Index<ApiCatalogRecord> CatalogRecords(MemoryAddress @base, ReadOnlySpan<ApiMember> members)
        {
            var count = members.Length;
            var buffer = alloc<ApiCatalogRecord>(count);
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
                record.PartName = member.Host.Owner.Format();
                record.OpUri = member.OpUri.UriText;
            }
            return buffer;
        }

        public Index<ApiCatalogRecord> LoadApiCatalog()
        {
            var dir = Db.IndexDir<ApiCatalogRecord>();
            var files = dir.Files(FS.Extensions.Csv).OrderBy(f => f.Name);
            var parser = Records.parser<ApiCatalogRecord>(parse);
            var rows = root.list<ApiCatalogRecord>();
            if(files.Length != 0)
            {
                var src = files[files.Length - 1];
                using var reader = src.Reader();
                var index = uint.MaxValue;
                reader.ReadLine();
                var line = reader.ReadLine();
                while(line != null)
                {
                    var outcome = parser.ParseRow(line, out var row);
                    if(outcome)
                        rows.Add(row);
                    else
                    {
                        Wf.Error(outcome.Message);
                        return sys.empty<ApiCatalogRecord>();
                    }
                    line = reader.ReadLine();
                }
            }

            return rows.ToArray();
        }

        static Outcome parse(string src, out ApiCatalogRecord dst)
        {
            const char Delimiter = FieldDelimiter;
            const byte FieldCount = ApiCatalogRecord.FieldCount;

            var fields = RecUtil.fields(src,Delimiter).View;
            if(fields.Length != FieldCount)
            {
                dst = default;
                return (false, Msg.FieldCountMismatch.Format(fields.Length, FieldCount, Format.delimit(fields, Delimiter)));
            }

            var i = 0;
            Numeric.parser<uint>().Parse(skip(fields, i++), out dst.Sequence);
            Addresses.parse(skip(fields, i++), out dst.ProcessBase);
            Addresses.parse(skip(fields, i++), out dst.MemberBase);
            Addresses.parse(skip(fields, i++), out dst.MemberOffset);
            Addresses.parse(skip(fields, i++), out dst.MemberRebase);
            ByteSize.parse(skip(fields, i++), out dst.MaxSize);
            dst.PartName = skip(fields, i++);
            dst.HostName = skip(fields, i++);
            dst.OpUri = skip(fields, i++);
            return true;
        }
    }
}