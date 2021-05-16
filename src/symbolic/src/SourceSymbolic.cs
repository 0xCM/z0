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

    using static Part;
    using static memory;
    using static Delegates;
    using static SFx;
    using static CodeSymbolModels;

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
        /// Computes the total number of members that can be obtained from specified source elements
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static uint MemberCount(ReadOnlySpan<TypeSymbol> src)
        {
            var count = src.Length;
            var total = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(src,i);
                if(symbol.IsNonEmpty)
                {
                    var members = symbol.GetMembers();
                    total += (uint)members.Length;
                }
            }
            return total;
        }

        Roslyn Roslyn;

        protected override void OnInit()
        {
            Roslyn = Wf.Roslyn();
        }


        public ReadOnlySpan<MethodSymbol> SymbolizeMethods(PartId id)
        {
            if(Wf.ApiCatalog.FindComponent(id, out var assembly))
            {
                return SymbolizeMethods(assembly);
            }
            else
                return default;
        }

        public ReadOnlySpan<MethodSymbol> SymbolizeMethods(Assembly src)
        {
            var symbols = Symbolize(src);
            return symbols.Methods;
        }

        public void SymbolizeMethods(ReadOnlySpan<Assembly> src, SpanReceiver<MethodSymbol> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var a = ref skip(src,i);
                dst(SymbolizeMethods(a));
            }
        }

        public CodeSymbolSet Symbolize(Assembly src)
        {
            var metadata = Cli.MetadataRef(src);
            var dst = CodeSymbols.set(metadata);
            var name = string.Format("{0}.compilation",src.GetSimpleName());
            var comp = Roslyn.Compilation(metadata, name);
            var assemlby = comp.GetAssemblySymbol(metadata);
            dst.Replace(array(assemlby));
            var gns = assemlby.GlobalNamespace;
            var types = gns.GetTypes();
            Wf.Status(string.Format("Traversing {0} types", types.Length));
            dst.Replace(types);
            var allocation = span<CodeSymbol>(MemberCount(types));
            Wf.Status(string.Format("Traversing {0} type members", allocation.Length));
            IncludeMethods(types, allocation, ref dst);
            return dst;
        }

        [Op]
        void IncludeMethods(ReadOnlySpan<TypeSymbol> src, Span<CodeSymbol> buffer, ref CodeSymbolSet dst)
        {
            var kIn = src.Length;
            var target = buffer;
            var offset = 0u;
            for(var i=0; i<kIn; i++)
            {
                var members = skip(src,i).GetMembers();
                var count = filter(members, SymbolKind.Method, target);
                target = slice(buffer, offset, count);
                offset += count;
            }

            var collected = slice(buffer, 0, offset);
            var kNonEmpty = NonEmpty(collected, collected);
            collected = slice(buffer, 0, kNonEmpty);

            Wf.Status(string.Format("Collected {0} methods", collected.Length));
            dst.Replace(CodeSymbols.convert<MethodSymbol>(collected));
        }

        [MethodImpl(Inline),Op]
        static uint NonEmpty(ReadOnlySpan<CodeSymbol> src, Span<CodeSymbol> dst)
        {
            var counter = 0u;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(src,i);
                if(symbol.IsNonEmpty)
                    seek(dst,counter++) = symbol;
            }
            return counter;
        }

        public readonly struct SymbolKindFilter : IUnaryPred<SymbolKindFilter,CodeSymbol>
        {
            public SymbolKind Kind {get;}

            [MethodImpl(Inline), Op]
            public SymbolKindFilter(SymbolKind kind)
                => Kind = kind;

            [MethodImpl(Inline), Op]
            public bit Invoke(CodeSymbol a)
                => a.Kind == Kind;
        }

        public readonly struct MemberProducer : IReadOnlySpanFactory<MemberProducer, TypeSymbol, CodeSymbol>
        {
            [MethodImpl(Inline), Op]
            public ReadOnlySpan<CodeSymbol> Invoke(in TypeSymbol src)
                => src.GetMembers();
        }

        public CodeSymbolSet Symbolize(PartId part)
        {
            var tool = Wf.Roslyn();
            if(Wf.ApiCatalog.FindComponent(part, out var assembly))
            {
                return Symbolize(assembly);
            }
            else
            {
                Wf.Error(string.Format("{0} not founc", part.Format()));
                return CodeSymbolSet.Empty;
            }
        }
    }
}