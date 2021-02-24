//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static memory;
    using static Part;
    using static TextRules;

    sealed class ApiServices : WfService<ApiServices,IApiServices>, IApiServices
    {
        public IApiJit ApiJit()
            => Z0.ApiJit.create(Wf);

        public Index<DataType> DataTypes()
            => Z0.DataTypes.search(Wf.Components);

        public IApiHexIndex HexIndexService()
            => ApiHexIndex.create(Wf);

        public BasedApiMemberCatalog RebaseMembers()
        {
            var jitter = ApiJit();
            var members = jitter.JitApi();
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

        void EmitSymbolicLiterals(IWfShell wf)
        {
            var target = Db.IndexTable(SymbolicLiteral.TableId);
            var components = wf.Components;
            EmitSymbolicLiterals(wf.Components, target);
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
                record.OpId = member.Id;
            }
            return buffer;
        }

        public Index<ApiCatalogRecord> LoadRebaseEntries()
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

            var fields = Records.fields(src,Delimiter).View;
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
            dst.OpId = OpIdentity.define(skip(fields, i++));
            return true;
        }

        partial struct Msg
        {
            public static RenderPattern<Count,Count,string> FieldCountMismatch => "{0} fields were found while {1} were expected: {2}";
        }
    }
}