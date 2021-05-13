//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using Microsoft.CodeAnalysis;

    using static CodeSymbolics;

    using static Part;
    using static memory;
    using static SFx;

    [ApiHost]
    public sealed class SourceSymbolic : AppService<SourceSymbolic>
    {
        [MethodImpl(Inline), Op]
        public static SymbolKindFilter filter(SymbolKind kind)
            => new SymbolKindFilter(kind);

        [MethodImpl(Inline), Op]
        public static uint filter(ReadOnlySpan<CodeSymbol> src, SymbolKind kind, Span<CodeSymbol> dst)
            => SFx.filter(src, filter(kind), dst);

        [MethodImpl(Inline), Op]
        public static MemberProducer producer()
            => new MemberProducer();

        /// <summary>
        /// Computes the maximum number of members supplied by a given element in the source
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static uint MaxMembers(ReadOnlySpan<TypeSymbol> src)
            => SpanCalcs.max(src,producer());

        /// <summary>
        /// Computes the maximum number of members supplied by a given element in the source
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static uint MemberCount(ReadOnlySpan<TypeSymbol> src)
            => SpanCalcs.count(src,producer());

        public SymbolSet Symbolize(Assembly src)
        {
            var metadata = MetadataReferences.from(src);
            var dst = SymbolSet.create(metadata);
            var tool = Wf.Roslyn();
            var name = string.Format("{0}.compilation",src.GetSimpleName());
            var comp = tool.Compilation(metadata, name);
            var assemlby = comp.GetAssemblySymbol(metadata);
            dst.Replace(array(assemlby));
            var gns = assemlby.GlobalNamespace;
            var types = gns.GetTypes();
            dst.Replace(types);
            var allocation = span<CodeSymbol>(MemberCount(types));
            IncludeMethods(types, allocation, dst);
            return dst;
        }

        [Op]
        SymbolSet IncludeMethods(ReadOnlySpan<TypeSymbol> src, Span<CodeSymbol> buffer, SymbolSet dst)
        {
            var kIn = src.Length;
            var target = buffer;
            var offset = 0u;
            for(var i=0; i<kIn; i++)
            {
                var count = filter(skip(src,i).GetMembers(), SymbolKind.Method, target);
                target = slice(buffer,offset,count);
                offset += count;
            }

            dst.Replace(CodeSymbols.convert<MethodSymbol>(slice(buffer, offset)));
            return dst;
        }

        public readonly struct SymbolKindFilter : IUnaryPred<CodeSymbol>
        {
            public SymbolKind Kind {get;}

            [MethodImpl(Inline), Op]
            public SymbolKindFilter(SymbolKind kind)
                => Kind = kind;

            public bit Invoke(CodeSymbol a)
                => a.Kind == Kind;
        }

        public readonly struct MemberProducer : IReadOnlySpanFactory<TypeSymbol, CodeSymbol>
        {
            public ReadOnlySpan<CodeSymbol> Invoke(in TypeSymbol src)
                => src.GetMembers();
        }

        public SymbolSet Symbolize(PartId part)
        {
            var tool = Wf.Roslyn();
            if(Wf.ApiCatalog.FindComponent(part, out var assembly))
            {
                return Symbolize(assembly);
            }
            else
            {
                Wf.Error(string.Format("{0} not founc", part.Format()));
                return SymbolSet.Empty;
            }
        }
    }
}