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

    public readonly struct Extraction
    {
        public static MemoryBlock block(in ApiExtractBlock src, TermInfo term)
        {
            if(term.IsEmpty)
                return MemoryBlock.Empty;

            var kind = term.Kind;
            var size = ByteSize.Zero;
            var modifier = skip(TermModifiers,(byte)kind);
            if(kind == TermKind.Term5A)
            {
                size = term.Offset + modifier;
            }
            else
            {
                size = term.Offset;
            }

            var origin = new MemoryRange(src.BaseAddress, size);
            var data = slice(src.View,0, size);
            return memory.block(origin, data.ToArray());

        }

        public static TermInfo terminal(in ApiExtractBlock src)
        {
            const byte MaxSeg = 6;

            var data = src.View;
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

            return new TermInfo(kind,(uint)found);
        }

        public static uint terminals(ReadOnlySpan<ApiExtractBlock> src, Span<MemoryBlock> dst)
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

            public uint Offset {get;}

            [MethodImpl(Inline)]
            public TermInfo(TermKind kind, uint offset)
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
                get => Kind != TermKind.None && Offset != 0;
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

        protected override void OnInit()
        {
            ExtractPipe = Wf.ApiExtractPipe();
            Parser = ApiExtracts.parser();
            Extractor = Wf.ApiExtractor();
            Resolver = Wf.ApiResolver();
            Decoder = Wf.AsmDecoder();
            Formatter = Wf.AsmFormatter();
        }

        /// <summary>
        /// Tests for a terminal opcode sequence
        /// </summary>
        /// <param name="a0"></param>
        /// <param name="a1"></param>
        /// <returns>
        /// This follows https://github.com/microsoft/Detours/samples/disas/disas.cpp, but seems to miss a lot
        /// </returns>
        [MethodImpl(Inline), Op]
        static byte terminal(byte a0, byte a1)
        {
            if(0xC3 == a0 && 0x00 == a1)
                return 2;

            if (0xCB == a0 || 0xC2 == a0 || 0xCA == a0 || 0xEB == a0 || 0xE9 == a0 || 0xEA == a0)
                return 1;

            if(0xff == a0 && 0x25 == a1)
                return 2;

            return 0;
        }

        void ExtractPart(IPart src, FS.FolderPath dst)
        {
            var resolved = Resolver.ResolvePart(src, out var _);
            var extracted = Extractor.ExtractPart(resolved).Sort();
            var path = dst + FS.file(string.Format("{0}.{1}", src.Id.Format(), "extracts"), FS.XPack);
            Emit(extracted, path);
        }

        public static FS.FileName file(ApiHostUri host, string subject, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}.{2}", host.Part.Format(), host.Name, subject), ext);

        public static FS.FolderName folder(PartId part)
            => FS.folder(part.Format());

        Index<ApiExtractBlock> ExtractHost(IApiHost src, FS.FilePath dst)
        {
            var resolved = Resolver.ResolveHost(src);
            var extracted = Extractor.ExtractHost(resolved).Sort();
            Emit(extracted, dst);
            return extracted;
        }

        Index<ApiExtractBlock> ExtractHost(IApiHost src)
        {
            var resolved = Resolver.ResolveHost(src);
            var extracted = Extractor.ExtractHost(resolved).Sort();
            return extracted;
        }

        Index<ApiCodeBlock> ParseExtracts(ReadOnlySpan<ApiExtractBlock> src)
        {
            var count = src.Length;
            var buffer = alloc<ApiCodeBlock>(count);
            ref var parsed = ref first(buffer);
            for(var i=0; i<count; i++)
                Parser.Parse(skip(src,i), out seek(parsed,i));
            return buffer;
        }

        Index<AsmInstructionBlock> DecodeParsed(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            var buffer = alloc<AsmInstructionBlock>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                Decoder.Decode(skip(src,i), out seek(dst,i));
            }
            return buffer;
        }

        uint Emit(ReadOnlySpan<ApiExtractBlock> src, FS.FilePath dst)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;

            var blocks = alloc<MemoryBlock>(count);
            var found = Extraction.terminals(src, blocks);
            var packed = CodeBlocks.pack(blocks);
            Wf.HexPacks().Emit(packed, dst);
            Wf.Status(string.Format("Identified {0} terminals from {1} methods", found, count));
            return count;
        }

        uint Emit(ReadOnlySpan<ApiCodeBlock> src, FS.FilePath dst)
        {
            var count = (uint)src.Length;
            if(count == 0)
                return 0;
            var packed = CodeBlocks.pack(src);
            Wf.HexPacks().Emit(packed, dst);
            return count;
        }

        uint Emit(ReadOnlySpan<AsmInstructionBlock> src, FS.FilePath dst)
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
                {
                    writer.WriteLine(Formatter.Format(block));
                    writer.WriteLine(RP.PageBreak160);
                }
            }
            Wf.EmittedFile(flow,count);

            return count;
        }

        void ExtractCatalog()
        {
            var catalog = Wf.ApiCatalog;
            var resolved = Resolver.ResolveCatalog(catalog);
            var extracted = Extractor.ExtractParts(resolved).Sort();
            Emit(extracted,Db.AppLog("extracts", FS.XPack));
        }

        void ExtractHosts(ApiHosts src, FS.FolderPath dir)
        {
            var count = src.Count;
            var hosts = src.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var extracts = ExtractHost(host);
                Emit(extracts, dir + file(host.HostUri, "extracts", FS.XPack));
                var parsed = ParseExtracts(extracts);
                Emit(parsed, dir + file(host.HostUri, "parsed", FS.XPack));
                var decoded = DecodeParsed(parsed);
                Emit(decoded, dir + file(host.HostUri, "decoded", FS.Asm));
            }
        }

        void ExtractParts(ReadOnlySpan<IApiPartCatalog> src, FS.FolderPath dir)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(src,i);
                var dst = dir + folder(part.PartId);
                ExtractHosts(part.ApiHosts,dst);
            }
        }

        public void Run()
        {
            var catalog = Wf.ApiCatalog;
            var dir = Db.AppLogDir();
            ExtractParts(catalog.PartCatalogs(), dir);
        }
    }
}