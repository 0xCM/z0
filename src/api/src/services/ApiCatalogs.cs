//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static memory;
    using static Sequential;

    [ApiHost]
    public class ApiCatalogs : WfService<ApiCatalogs>
    {
        ApiJit ApiJit;

        protected override void OnInit()
        {
            ApiJit = Wf.ApiJit();
        }

        public Index<ApiCatalogEntry> RebaseMembers(ApiMembers src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<ApiCatalogEntry>(dst);
            var records = ApiCatalogs.rebase(src.BaseAddress, src.View);
            var count = Tables.emit<ApiCatalogEntry>(records, dst, 16);
            Wf.EmittedTable<ApiCatalogEntry>(flow, count, dst);
            return records;
        }

        public Index<ApiCatalogEntry> Current()
        {
            var dir = Db.IndexDir<ApiCatalogEntry>();
            var files = dir.Files(FS.Csv).OrderBy(f => f.Name);
            var parser = Tables.parser<ApiCatalogEntry>(parse);
            var rows = root.list<ApiCatalogEntry>();
            if(files.Length != 0)
            {
                var src = files[files.Length - 1];
                var flow = Wf.Running(string.Format("Loading api catalog from {0}", src.ToUri()));

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
                        return sys.empty<ApiCatalogEntry>();
                    }
                    line = reader.ReadLine();
                }

                Wf.Ran(flow, text.format("Loaded {0} api catalog entries from {1}", rows.Count, src.ToUri()));
            }

            return rows.ToArray();
        }

        static Outcome parse(string src, out ApiCatalogEntry dst)
        {
            const char Delimiter = FieldDelimiter;
            const byte FieldCount = ApiCatalogEntry.FieldCount;

            var fields = Tables.fields(src, Delimiter).View;
            if(fields.Length != FieldCount)
            {
                dst = default;
                return (false, Msg.FieldCountMismatch.Format(fields.Length, FieldCount, text.delimit(fields, Delimiter)));
            }

            var i = 0;
            DataParser.parse(skip(fields, i++), out dst.Sequence);
            DataParser.parse(skip(fields, i++), out dst.ProcessBase);
            DataParser.parse(skip(fields, i++), out dst.MemberBase);
            DataParser.parse(skip(fields, i++), out dst.MemberOffset);
            DataParser.parse(skip(fields, i++), out dst.MemberRebase);
            DataParser.parse(skip(fields, i++), out dst.MaxSize);
            DataParser.parse(skip(fields, i++), out dst.PartName);
            DataParser.parse(skip(fields, i++), out dst.HostName);
            DataParser.parse(skip(fields, i++), out dst.OpUri);
            return true;
        }

        /// <summary>
        /// Returns a <see cref='ApiHostCatalog'/> for a specified host
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="src">The host type</param>
        public ApiHostCatalog HostCatalog(Type src)
            => HostCatalog(ApiCatalogs.host(src));

        /// <summary>
        /// Returns a <see cref='ApiHostCatalog'/> for a specified host
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="src">The host type</param>
        [Op]
        public ApiHostCatalog HostCatalog(IApiHost src)
        {
            var flow = Wf.Running(Msg.CreatingHostCatalog.Format(src.Uri));
            var members = ApiJit.JitHost(src);
            var result = members.Length == 0 ? ApiHostCatalog.Empty : new ApiHostCatalog(src, members.Sort());
            Wf.Ran(flow, Msg.CreatedHostCatalog.Format(src.Uri, members.Count));
            return result;
        }

        [Op]
        public static IApiParts parts()
            => parts(root.controller(), Environment.GetCommandLineArgs());

        [Op]
        public static IApiParts parts(FS.FolderPath src)
            => new ApiParts(src);

        /// <summary>
        /// Creates a <see cref='ApiParts'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static IApiParts parts(Assembly control, Index<PartId> identifiers)
        {
            if(identifiers.IsNonEmpty)
               return new ApiParts(identifiers);
            else
                return new ApiParts(FS.path(control.Location).FolderPath);
        }

        /// <summary>
        /// Creates a <see cref='ApiParts'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// where the entry assembly is assumed to be the locus of control
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static IApiParts parts(Index<PartId> identifiers)
            => parts(root.controller(), identifiers);

        [Op]
        public static IApiParts parts(Assembly control, string[] args)
        {
            if(args.Length != 0)
            {
                var identifiers = ApiPartIdParser.parse(args);
                if(identifiers.Length != 0)
                    return new ApiParts(identifiers);
            }

            return new ApiParts(FS.path(control.Location).FolderPath);
        }

        [Op]
        public static ApiHostInfo hostinfo(Type t)
        {
            var methods = t.DeclaredMethods();
            return new ApiHostInfo(t, t.HostUri(), t.Assembly.Id(), methods, index(methods));
        }

        [Op]
        public static ApiHostInfo hostinfo<T>()
            => hostinfo(typeof(T));

        [Op]
        public static Identifier hostname(Type src)
        {
            var attrib = src.Tag<ApiHostAttribute>();
            return text.ifempty(attrib.MapValueOrDefault(a => a.HostName, src.Name), src.Name).ToLower();
        }

        public static Dictionary<string,MethodInfo> index(Index<MethodInfo> methods)
        {
            var index = new Dictionary<string, MethodInfo>();
            root.iter(methods, m => index.TryAdd(ApiIdentity.identify(m).IdentityText, m));
            return index;
        }

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="type">The reifying type</param>
        [Op]
        public static ApiHost host(Type type)
        {
            var part = type.Assembly.Id();
            var name =  hostname(type);
            var declared = type.DeclaredMethods();
            return new ApiHost(type, name, part, new ApiHostUri(part, name), declared, index(declared));
        }

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static Type[] ServiceHostTypes(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        [Op]
        public static Index<ApiHost> hosts(Assembly src)
        {
            var _id = src.Id();
            return ApiHostTypes(src).Select(h => host(_id, h));
        }

        [Op]
        public static bool IsApiHost(Type src)
            => src.Tagged<ApiHostAttribute>();

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiHostAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static Index<Type> ApiHostTypes(Assembly src)
            => src.GetTypes().Where(IsApiHost);

        /// <summary>
        /// Describes an api host
        /// </summary>
        /// <param name="part">The defining part</param>
        /// <param name="t">The reifying type</param>
        [Op]
        public static ApiHost host(PartId part, Type type)
        {
            var name = hostname(type);
            var declared = type.DeclaredMethods();
            return new ApiHost(type, name, part, new ApiHostUri(part, name), declared, index(declared));
        }

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> for a specified part
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog catalog(IPart src)
            => catalog(src.Owner);

        /// <summary>
        /// Defines a <see cref='ApiPartCatalog'/> over a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static IApiPartCatalog catalog(Assembly src)
            => new ApiPartCatalog(src.Id(), src, ApiTypes(src), hosts(src), ServiceHostTypes(src));

        [Op]
        public static Index<ApiCatalogEntry> rebase(MemoryAddress @base, ReadOnlySpan<ApiMember> members)
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

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="ApiCompleteAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static ApiRuntimeType[] ApiTypes(Assembly src)
        {
            var part = src.Id();
            var types = span(src.GetTypes().Where(t => t.Tagged<ApiCompleteAttribute>()));
            var count = types.Length;
            var buffer = alloc<ApiRuntimeType>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var type = ref skip(types,i);
                var attrib = type.Tag<ApiCompleteAttribute>();
                var name =  text.ifempty(attrib.MapValueOrDefault(a => a.Name, type.Name),type.Name).ToLower();
                var uri = new ApiHostUri(part, name);
                var declared = type.DeclaredMethods();
                seek(dst, i) = new ApiRuntimeType(type, name, part, uri, declared, index(declared));
            }
            return buffer;
        }

        public static IPart[] PartsFromIdentities(PartId[] identities)
        {
            var dir = FS.path(root.controller().Location).FolderPath;
            var query = from p in identities
                        let @base = "z0." + p.Format()
                        from f in root.seq(FS.file(@base, FS.Dll), FS.file(@base,FS.Exe))
                        let path = dir + f
                        where path.Exists
                        let part = part(path)
                        where part.IsSome()
                        select part.Value;
            return query.ToArray();
        }

        public static FS.Files colocated()
            => FS.dir(root.controller().Location).TopFiles;

        public static Index<Assembly> components(PartId[] identities)
        {
            var dst = root.list<Assembly>();
            var dir = FS.dir(root.controller().Location);
            var candidates = colocated();
            foreach(var path in candidates)
            {
                if((path.Is(FS.Dll) || path.Is(FS.Exe)) && FS.managed(path))
                {
                    foreach(var id in identities)
                    {
                        var match = dir + FS.component(id, path.Ext);
                        if(match.Equals(path))
                            dst.Add(Assembly.LoadFrom(match.Name));
                    }

                }
            }

            return dst.ToArray();
        }

        public static IApiCatalogDataset dataset(IPart[] parts)
        {
            var catalogs = parts.Select(x => catalog(x) as IApiPartCatalog).Where(c => c.IsIdentified);
            var dst = new ApiCatalogDataset(parts,
                parts.Select(p => p.Owner),
                catalogs,
                catalogs.SelectMany(c => c.ApiHosts.Storage),
                parts.Select(p => p.Id),
                catalogs.SelectMany(x => x.Operations)
                );
            return dst;
        }

        [Op]
        public static IApiCatalogDataset dataset(PartId[] identities)
            => dataset(PartsFromIdentities(identities));

        /// <summary>
        /// Attempts to resolve a part from an assembly file path
        /// </summary>
        [Op]
        public static Option<IPart> part(FS.FilePath src)
            => from c in component(src)
            from t in resolve(c)
            from p in resolve(t)
            from part in resolve(p)
            select part;

        [Op]
        public static IApiCatalogDataset dataset(FS.Files paths)
            => dataset(paths.Storage.Select(part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id));

        [Op]
        public static IApiCatalogDataset dataset(FS.FolderPath src, PartId[] parts)
            => dataset(src.Exclude("System.Private.CoreLib").Where(f => FS.managed(f)));

        /// <summary>
        /// Loads an assembly from a potential part path
        /// </summary>
        [Op]
        public static Option<Assembly> component(FS.FilePath src)
        {
            try
            {
                return Assembly.LoadFrom(src.Name);
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        [Op]
        public static Assembly[] components(FS.FilePath[] src)
            => src.Map(component).Where(x => x.IsSome()).Select(x => x.Value).Where(nonempty);

        /// <summary>
        /// Attempts to resolve a part resolution type
        /// </summary>
        static Option<Type> resolve(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part resolution property
        /// </summary>
        static Option<PropertyInfo> resolve(Type src)
            => src.StaticProperties().Where(p => p.Name == "Resolved").FirstOrDefault();

        /// <summary>
        /// Attempts to resolve a part from a resolution property
        /// </summary>
        [Op]
        static Option<IPart> resolve(PropertyInfo src)
            => root.@try(src, x => (IPart)x.GetValue(null));

        [Op]
        static bool nonempty(Assembly src)
            => src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Count() > 0;


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
                        var catalog = HostCatalog(Wf.Api.FindHost(host.Uri).Require());
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

    }
}