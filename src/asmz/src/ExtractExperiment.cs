//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct Extraction
    {
        [Op]
        public static MemoryBlock block(in ApiMemberCode src, TermInfo term)
        {
            if(term.IsEmpty)
                return MemoryBlock.Empty;

            var kind = term.Kind;
            var size = ByteSize.Zero;
            var modifier = skip(TermModifiers,(byte)kind);
            if(kind == TermKind.Term5A)
                size = term.Offset + modifier;
            else
                size = term.Offset;

            var origin = new MemoryRange(src.Address, size);
            var data = slice(src.Encoded.View,0, size);
            return memory.block(origin, data.ToArray());
        }

        [Op]
        public static TermInfo terminal(in ApiMemberCode src)
        {
            const byte MaxSeg = 6;

            var data = src.Encoded.View;
            var size = data.Length;
            var found = NotFound;
            var max = size + MaxSeg - 1;
            var kind = TermKind.None;
            for(var offset=0; offset<max; offset++)
            {
                if(slice(data, offset, 3).SequenceEqual(Term3A))
                {
                    found = offset;
                    kind = TermKind.Term3A;
                    break;
                }
                else if(slice(data, offset, 6).SequenceEqual(Term6A))
                {
                    found = offset;
                    kind = TermKind.Term6A;
                    break;
                }
                else if(slice(data, offset, 5).SequenceEqual(Term5A))
                {
                    found = offset;
                    kind = TermKind.Term5A;
                    break;
                }
                else if(slice(data, offset, 4).SequenceEqual(Term4A))
                {
                    found = offset;
                    kind = TermKind.Term4A;
                    break;
                }
                else if(slice(data, offset, 3).SequenceEqual(Term3B))
                {
                    found = offset;
                    kind = TermKind.Term3B;
                    break;
                }
                else if(slice(data, offset, 4).SequenceEqual(Term4B))
                {
                    found = offset;
                    kind = TermKind.Term4B;
                    break;
                }
            }

            return new TermInfo(kind, found);
        }

        [Op]
        public static uint terminals(ReadOnlySpan<ApiMemberCode> src, Span<MemoryBlock> dst)
        {
            var count = src.Length;
            var j = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var extract = ref skip(src,i);
                var term = terminal(extract);
                if(term.IsNonEmpty)
                    seek(dst, j++) = block(extract, term);
            }
            return j;
        }

        public enum TermKind : sbyte
        {
            None = -1,

            Term3A = 0,

            Term3B = 1,

            Term4A = 2 ,

            Term4B = 3,

            Term5A = 4,

            Term6A = 5
        }

        public readonly struct TermInfo
        {
            public TermKind Kind {get;}

            public int Offset {get;}

            [MethodImpl(Inline)]
            public TermInfo(TermKind kind, int offset)
            {
                Offset = offset;
                Kind = kind;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Kind == TermKind.None;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Kind != TermKind.None && Offset > 0;
            }

            public static TermInfo Empty
            {
                [MethodImpl(Inline)]
                get => new TermInfo(TermKind.None, 0);
            }
        }

        const byte SBB = 0x19;

        const byte RET = 0xc3;

        const byte INT3 = 0xcc;

        // cc cc cc
        internal static ReadOnlySpan<byte> Term3A => new byte[3]{INT3, INT3, INT3};

        internal const sbyte Term3AModifier = -3;

        // cc 00 19
        internal static ReadOnlySpan<byte> Term3B => new byte[3]{INT3, 0, SBB};

        internal const sbyte Term3BModifier = -3;

        //c3 00 00 19
        internal static ReadOnlySpan<byte> Term4A => new byte[4]{RET, 0, 0, SBB};

        internal const sbyte Term4AModifier = -3;

        /// c3 19 01 01
        internal static ReadOnlySpan<byte> Term4B => new byte[4]{RET, SBB, 0x01, 0x01};

        internal const sbyte Term4BModifier = -3;

        // 00 00 00 00 00
        internal static ReadOnlySpan<byte> Term5A => new byte[5]{0, 0, 0, 0, 0};

        internal const sbyte Term5Modifier = -5;

        //19 00 00 00 40 00
        internal static ReadOnlySpan<byte> Term6A => new byte[6]{SBB, 0, 0, 0, 0x40, 0};

        internal const sbyte Term6AModifier = -6;

        internal static ReadOnlySpan<sbyte> TermModifiers => new sbyte[6]{Term3AModifier,Term3BModifier,Term4AModifier, Term4BModifier,Term5Modifier,Term6AModifier};
    }

    [ApiHost]
    class ExtractExperiment : AppService<ExtractExperiment>
    {
        ApiExtractPipe ExtractPipe;

        ApiExtractParser Parser;

        ApiExtractor Extractor;

        ApiResolver Resolver;

        AsmRoutineDecoder Decoder;

        AsmFormatter Formatter;

        HexPacks HexPacks;

        protected override void OnInit()
        {
            ExtractPipe = Wf.ApiExtractPipe();
            Parser = ApiExtracts.parser();
            Extractor = Wf.ApiExtractor();
            Resolver = Wf.ApiResolver();
            Decoder = Wf.AsmDecoder();
            Formatter = Wf.AsmFormatter();
            HexPacks = Wf.HexPacks();
        }

        ApiHostExtracts ExtractHost(IApiHost src, FS.FilePath dst)
        {
            var resolved = Resolver.ResolveHost(src);
            var extracted = Extractor.ExtractHost(resolved).Sort();
            Emit(extracted.View, dst);
            return extracted;
        }

        ApiHostExtracts ExtractHost(IApiHost src)
        {
            var resolved = Resolver.ResolveHost(src);
            var extracted = Extractor.ExtractHost(resolved).Sort();
            return extracted;
        }

        Index<ApiMemberCode> ParseExtracts(ReadOnlySpan<ApiMemberExtract> src)
        {
            var count = src.Length;
            var buffer = alloc<ApiMemberCode>(count);
            ref var parsed = ref first(buffer);
            for(var i=0; i<count; i++)
                Parser.Parse(skip(src,i), out seek(parsed,i));
            return buffer;
        }

        Index<AsmRoutine> DecodeParsed(ReadOnlySpan<ApiMemberCode> src)
        {
            var count = src.Length;
            var buffer = alloc<AsmRoutine>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                var decoded = Decoder.Decode(skip(src,i));
                if(decoded)
                {
                    seek(dst,i) = decoded.Value;
                }
            }
            return buffer;
        }

        uint Emit(ReadOnlySpan<ApiMemberCode> src, FS.FilePath dst)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;

            var blocks = alloc<MemoryBlock>(count);
            var found = Extraction.terminals(src, blocks);
            var packed = CodeBlocks.pack(blocks);
            HexPacks.Emit(packed, dst);
            Wf.Status(string.Format("Identified {0} terminals from {1} methods", found, count));
            return count;
        }

        uint Emit(ReadOnlySpan<ApiMemberExtract> src, FS.FilePath dst)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;
            var packed = CodeBlocks.pack(src);
            HexPacks.Emit(packed, dst);
            return count;
        }

        uint Emit(ReadOnlySpan<AsmRoutine> src, FS.FilePath dst)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                if(block.IsNonEmpty)
                    writer.Write(Formatter.Format(block));
            }
            Wf.EmittedFile(flow,count);

            return count;
        }

        void ExtractCatalog()
        {
            var catalog = Wf.ApiCatalog;
            var resolved = Resolver.ResolveCatalog(catalog);
            var extracted = Extractor.ExtractParts(resolved).Sort();
            Emit(extracted, Db.AppLog("extracts", FS.XPack));
        }

        void ExtractHosts(ApiHosts src, FS.FolderPath dir)
        {
            var count = src.Count;
            if(count == 0)
                return;

            var hosts = src.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var extracts = ExtractHost(host);
                Emit(extracts.View, dir + FS.file(host.HostUri, "extracts", FS.XPack));
                var parsed = ParseExtracts(extracts.View);
                Emit(parsed, dir + FS.file(host.HostUri, "parsed", FS.XPack));
                var decoded = DecodeParsed(parsed);
                Emit(decoded, dir + FS.file(host.HostUri, FS.Asm));
            }
        }

        void ExtractParts(ReadOnlySpan<IApiPartCatalog> src, FS.FolderPath dir)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(src,i);
                var dst = dir + FS.folder(part.PartId);
                ExtractHosts(part.ApiHosts,dst);
            }
        }

        public void Run()
        {
            var catalog = Wf.ApiCatalog;
            var dir = Db.AppLogDir();
            dir.Clear(true);
            ExtractParts(catalog.PartCatalogs(), dir);
        }
    }
}