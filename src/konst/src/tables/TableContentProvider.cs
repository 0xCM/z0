//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;

    using static z;

    public readonly struct TableContentProvider : IContentProvider
    {
        public static TableContentProvider create()
            => default(TableContentProvider);

        public IEnumerable<DocLibEntry> Provided
        {
            get
            {
                var names = Extractor.ResourceNames;
                foreach(var name in names)
                {
                    yield return new DocLibEntry(name, Path.GetExtension(name));
                }
            }
        }

        /// <summary>
        /// Searches for embedded content with a matching identifier and, if found,
        /// returns the first matching resource; otherwise returns an empty resource
        /// </summary>
        /// <param name="match">The resource identifier to match</param>
        [Op]
        public AppResource Search(string match)
        {
            try
            {
                return Extractor.Extract(x => x.Contains(match));
            }
            catch(Exception e)
            {
                term.error(e);
                return AppResource.Empty;
            }
        }

        /// <summary>
        /// Enumerates embedded content with matching kind
        /// </summary>
        /// <param name="kind">The kind to match</param>
        [Op]
        static IEnumerable<AppResource> match(DocContentKind kind)
        {
            var svc = Extractor;
            var names = svc.ResourceNames;
            var matches = kind switch {
                DocContentKind.AsmAlgorithms => names.Where(name => name.Contains($".asm.") && name.Contains($".algorithms.")),
                DocContentKind.AsmIdentifiers => names.Where(name => name.Contains($".asm.") && name.Contains($".identifiers.")),
                DocContentKind.AsmBitfields => names.Where(name => name.Contains($".asm.") && name.Contains($".bitfields.")),
                DocContentKind.AsmInstructions => names.Where(name => name.Contains($".asm.") && name.Contains($".instructions.")),
                DocContentKind.AsmSyntax => names.Where(name => name.Contains($".asm.") && name.Contains($".syntax.")),
                DocContentKind.PeFormat => names.Where(name => name.Contains($".images.") && name.Contains($".pe.")),
                DocContentKind.Tools => names.Where(name => name.Contains(".tools.")),
                DocContentKind.Xml => names.Where(name => name.Contains(".xml.")),

                    _ => sys.empty<string>(),
            };

            foreach(var match in matches)
                yield return svc.Extract(match);
        }

        static string format(DocContentKind src)
            => src.ToString().ToLower();

        static string format(DocStructureKind src)
            => src.ToString().ToLower();

        /// <summary>
        /// Returns supported content kinds
        /// </summary>
        static DocContentKind[] ContentClasses
            => Enums.literals<DocContentKind>().Where(x => x != 0).OrderBy(x => format(x));

        /// <summary>
        /// Returns supported content kinds
        /// </summary>
        static DocStructureKind[] StructuredClasses
            => Enums.literals<DocStructureKind>().Where(x => x != 0).OrderBy(x => format(x));

        [Op]
        static ReadOnlySpan<SystemImageSymbol> SystemImages
        {
            get
            {
                var doc = structured(nameof(SystemImages));
                if(doc.RowCount != 0)
                {
                    var dst = sys.alloc<SystemImageSymbol>(doc.RowCount);
                    for(var i=0; i<doc.RowCount; i++)
                    {
                        ref readonly var row = ref doc[i];
                        if(row.CellCount >= 2)
                            dst[i] = new SystemImageSymbol(row[0], row[1]);
                    }
                    return dst;
                }
                return sys.empty<SystemImageSymbol>();
            }
        }

        /// <summary>
        /// Enumerates all content
        /// </summary>
        [Op]
        static IEnumerable<Paired<DocContentKind,AppResource>> Content
        {
            get
            {
                foreach(var k in ContentClasses)
                    foreach(var res in match(k))
                        yield return (k,res);
            }
        }

        /// <summary>
        /// Searches for an embedded document with a matching identifier and, if found,
        /// returns the first match; otherwise returns an empty document
        /// </summary>
        /// <param name="match">The resource identifier to match</param>
        static AppResourceDoc structured(string match)
            => Extractor.MatchDocument(match);

        /// <summary>
        /// Enumerates all structured content
        /// </summary>
        static IEnumerable<Paired<DocStructureKind,AppResourceDoc>> Structured
        {
            get
            {
                foreach(var k in StructuredClasses)
                    foreach(var doc in match(k))
                        yield return z.paired(k,doc);
            }
        }

        /// <summary>
        /// Enumerates embedded documents with matching kind
        /// </summary>
        /// <param name="kind">The kind to match</param>
        static IEnumerable<AppResourceDoc> match(DocStructureKind kind)
        {
            var svc = Extractor;
            var names = svc.ResourceNames;
            var matches = kind switch {
                DocStructureKind.AsmIdentifiers => names.Where(name => name.Contains(".asmid.")),
                DocStructureKind.AsmInstructions => names.Where(name => name.Contains(".asminxs.")),
                DocStructureKind.AsmSyntax => names.Where(name => name.Contains(".asmsyn.")),
                DocStructureKind.AsmBitFields => names.Where(name => name.Contains(".asmt.")),
                    _ => sys.empty<string>(),
            };

            foreach(var match in matches)
            {
                var doc = svc.ExtractDocument(match);
                if(doc.Succeeded)
                    yield return doc.Value;
            }
        }

        static ResExtractor Extractor
            => ResExtractor.Service(typeof(Z0.Parts.Data).Assembly);
    }
}