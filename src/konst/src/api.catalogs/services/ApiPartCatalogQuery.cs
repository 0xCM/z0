//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;

    using F = ApiParseField;

    [ApiHost(ApiNames.ApiParseBlocks, true)]
    public readonly struct ApiParseBlocks
    {
        public static string format(in ApiParseBlock src, char delimiter)
        {
            var dst = Table.formatter<F>(delimiter);
            dst.Delimit(F.Seq, src.Seq);
            dst.Delimit(F.SourceSeq, src.SourceSeq);
            dst.Delimit(F.Address, src.Address);
            dst.Delimit(F.Length, src.Length);
            dst.Delimit(F.TermCode, src.TermCode);
            dst.Delimit(F.Uri, src.Uri);
            dst.Delimit(F.OpSig, src.OpSig);
            dst.Delimit(F.Data, src.Data.Format());
            return dst.Format();
        }
        [Op]
        public static ParseResult<ApiParseBlock[]> load(FS.FilePath src)
        {
            var attempts = src.ReadLines().Skip(1).Select(row);
            var failed = attempts.Where(r => !r.Succeeded);
            var success = attempts.Where(r => r.Succeeded).Select(r => r.Value);
            if(failed.Length != 0 && success.Length == 0)
                return ParseResult.Fail<ApiParseBlock[]>(src.Name, failed[0].Message);
            else
                return ParseResult.Success<ApiParseBlock[]>(src.Name, success);
        }

        [Op]
        public static ApiParseBlock[] create(ApiHostUri host, ApiMemberCodeBlocks members)
        {
            var count = members.Count;
            var buffer = alloc<ApiParseBlock>(count);
            var dst = span(buffer);
            var src = members.View;
            for(var i=0u; i<count; i++)
                seek(dst,i) = record(skip(src,i), i);
            return buffer;
        }

        [MethodImpl(Inline)]
        public static ApiParseBlock record(in ApiMemberCode src, uint seq)
        {
            var dst = new ApiParseBlock();
            dst.Seq = (int)seq;
            dst.SourceSeq = (int)src.Sequence;
            dst.Address = src.Address;
            dst.Length = src.Encoded.Length;
            dst.TermCode = src.TermCode;
            dst.Uri = src.OpUri;
            dst.OpSig = src.Method.Metadata().Format();
            dst.Data = src.Encoded;
            return dst;
        }

        static TableArchive<ApiParseField,ApiParseBlock> Store => default;

        [MethodImpl(Inline), Op]
        public static Option<FS.FilePath> save(ApiParseBlock[] src, FS.FilePath dst)
            => Store.Save(src, dst);

        [Op]
        static ParseResult<ApiParseBlock> row(string src)
        {
            try
            {
                var fields = src.SplitClean(FieldDelimiter);
                if(fields.Length !=  (uint)ApiParseBlock.FieldCount)
                    return ParseResult.Fail<ApiParseBlock>(src,"No data");

                var dst = new ApiParseBlock();
                var index = 0;
                dst.Seq = NumericParser.succeed<int>(fields[index++]);
                dst.SourceSeq = NumericParser.succeed<int>(fields[index++]);
                dst.Address = MemoryAddressParser.succeed(fields[index++]);
                dst.Length = NumericParser.succeed<int>(fields[index++]);
                dst.TermCode = Enums.parse(fields[index++], ExtractTermCode.None);
                dst.Uri = ApiUriParser.Service.Parse(fields[index++]).Require();
                dst.OpSig = fields[index++];
                dst.Data = new CodeBlock(dst.Address, Parsers.hex(true).ParseData(fields[index++], sys.empty<byte>()));
                return ParseResult.Success(src, dst);
            }
            catch(Exception e)
            {
                return ParseResult.Fail<ApiParseBlock>(src, e);
            }
        }
    }

    /// <summary>
    /// Defines a view over a <see cref='IApiPartCatalog'/>
    /// </summary>
    [ApiHost(ApiNames.ApiPartCatalogQuery, true)]
    public readonly struct ApiPartCatalogQuery
    {
        /// <summary>
        /// The catalog to interrogate
        /// </summary>
        public IApiPartCatalog Source {get;}

        [MethodImpl(Inline)]
        public ApiPartCatalogQuery(IApiPartCatalog src)
            => Source = src;

        [Op, MethodImpl(NotInline), Closures(UnsignedInts)]
        public MethodInfo[] Vectorized<T>(W128 w, bool generic)
            where T : unmanaged
                => (from host in Source.ApiHosts.Storage
                    from m in host.DeclaredMethods.VectorizedDirect<T>(w)
                    where m.IsGenericMethod == generic
                    select m).Array();

        public MethodInfo[] Generic
        {
            get => (from host in Source.ApiHosts.Storage
                from m in host.DeclaredMethods.OpenGeneric()
                select m).Array();
        }

        public MethodInfo[] Direct
        {
            [Op, MethodImpl(NotInline)]
            get => (from host in Source.ApiHosts.Storage
                from m in host.DeclaredMethods.NonGeneric()
                select m).Array();
        }

        [MethodImpl(NotInline), Op, Closures(UnsignedInts)]
        public MethodInfo[] Vectorized<T>(W256 w, bool generic)
            where T : unmanaged
                => (from host in Source.ApiHosts.Storage
                    from m in host.DeclaredMethods.VectorizedDirect<T>(w)
                    where m.IsGenericMethod == generic
                    select m).Array();

        [MethodImpl(NotInline), Op, Closures(UnsignedInts)]
        public MethodInfo[] Vectorized<T>(W128 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);

        [MethodImpl(NotInline), Op, Closures(UnsignedInts)]
        public MethodInfo[] Vectorized<T>(W256 w, bool generic, string name)
            where T : unmanaged
                => Vectorized<T>(w, generic).WithName(name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W128 w)
            => Generic.VectorizedGeneric(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W256 w)
            => Generic.VectorizedGeneric(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W512 w)
            => Generic.VectorizedGeneric(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W128 w, string name)
            => Generic.VectorizedGeneric(w,name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W256 w, string name)
            => Generic.VectorizedGeneric(w,name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedGeneric(W512 w, string name)
            => Generic.VectorizedGeneric(w,name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W128 w)
            => Direct.VectorizedDirect(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W256 w)
            => Direct.VectorizedDirect(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W512 w)
            => Direct.VectorizedDirect(w);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W128 w, string name)
            => Direct.VectorizedDirect(w, name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W256 w, string name)
            => Direct.VectorizedDirect(w, name);

        [MethodImpl(Inline), Op]
        public MethodInfo[] VectorizedDirect(W512 w, string name)
            => Direct.VectorizedDirect(w, name);
    }
}