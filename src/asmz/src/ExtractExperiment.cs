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

        protected override void OnInit()
        {
            ExtractPipe = Wf.ApiExtractPipe();
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


        HexPack Pack(ReadOnlySpan<ApiExtractBlock> src)
        {
            var count = src.Length;
            var buffer = alloc<MemoryBlock>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var extract = ref skip(src,i);
                seek(dst,i) = memory.block(extract.Origin, extract.Data);
            }
            return buffer;
        }


        void Trim(ReadOnlySpan<ApiExtractBlock> src)
        {
            var extracts = src;
            var count = extracts.Length;
            var blocks = alloc<MemoryBlock>(count);

            var j = 0;
            for(var i=0; i<count; i++)
            {
                ref readonly var extract = ref skip(extracts,i);
                var term = Extraction.terminal(extract);
                if(term.IsNonEmpty)
                    seek(blocks, j++) = Extraction.block(extract, term);
            }

            var hexpacks = Wf.HexPacks();
            var packed = Pack(extracts);
            var hexout = Db.AppLog("extracts", FS.XPack);
            Wf.HexPacks().Emit(blocks, hexout);
            Wf.Status(string.Format("Identified {0} terminals from {1} methods", j, count));

        }

        void ExtractPart(IPart src)
        {
            var extractor = Wf.ApiExtractor();
            var resolver = Wf.ApiResolver();
            var resolved = resolver.ResolvePart(src, out var _);
            var extracted = extractor.ExtractResolved(resolved).Sort();
            Trim(extracted.View);
        }

        void ExtractCatalog()
        {
            var extractor = Wf.ApiExtractor();
            var resolver = Wf.ApiResolver();
            var catalog = Wf.ApiCatalog;
            var resolved = resolver.ResolveCatalog(catalog);
            var extracted = extractor.ExtractResolved(resolved).Sort();
            Trim(extracted.View);
        }


        public void Run()
        {
            ExtractCatalog();

            // var parsed = parse(extracts);
            // var hex = Wf.ApiHex();
            // var packed = hex.BuildHexPack(parsed);
            // var outfile = Db.AppLog("apihex", FS.ext("xpack"));
            // hex.EmitHexPack(parsed.ToArray(), outfile);
        }
    }
}