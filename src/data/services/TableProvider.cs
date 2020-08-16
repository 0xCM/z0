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

    public readonly struct TableProvider : ITableProvider
    {
        public static TableProvider create()
            => default(TableProvider);
                
        public IEnumerable<ContentLibEntry> Provided
        {
            get
            {
                var names = Extractor.ResourceNames;
                foreach(var name in names)
                {                
                    yield return new ContentLibEntry(name, Path.GetExtension(name));
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
        static IEnumerable<AppResource> match(ContentKind kind)
        {
            var svc = Extractor;
            var names = svc.ResourceNames;
            var matches = kind switch {
                ContentKind.AsmAlgorithms => names.Where(name => name.Contains($".asm.") && name.Contains($".algorithms.")),                
                ContentKind.AsmIdentifiers => names.Where(name => name.Contains($".asm.") && name.Contains($".identifiers.")),
                ContentKind.AsmBitfields => names.Where(name => name.Contains($".asm.") && name.Contains($".bitfields.")),
                ContentKind.AsmInstructions => names.Where(name => name.Contains($".asm.") && name.Contains($".instructions.")),
                ContentKind.AsmSyntax => names.Where(name => name.Contains($".asm.") && name.Contains($".syntax.")),
                ContentKind.PeFormat => names.Where(name => name.Contains($".images.") && name.Contains($".pe.")),
                ContentKind.Tools => names.Where(name => name.Contains(".tools.")),
                ContentKind.Xml => names.Where(name => name.Contains(".xml.")),

                    _ => sys.empty<string>(),
            };
            
            foreach(var match in matches)
                yield return svc.Extract(match);
        }


        /// <summary>
        /// Returns supported content kinds
        /// </summary>
        static ContentKind[] ContentClasses
            => Enums.literals<ContentKind>().Where(x => x != 0).OrderBy(x => x.Format());

        /// <summary>
        /// Returns supported content kinds
        /// </summary>
        static StructureKind[] StructuredClasses
            => Enums.literals<StructureKind>().Where(x => x != 0).OrderBy(x => x.Format());

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
        static IEnumerable<Paired<ContentKind,AppResource>> Content
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
            => Extractor.MatcDocument(match);

        /// <summary>
        /// Enumerates all structured content
        /// </summary>
        static IEnumerable<Paired<StructureKind,AppResourceDoc>> Structured
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
        static IEnumerable<AppResourceDoc> match(StructureKind kind)
        {
            var svc = Extractor;
            var names = svc.ResourceNames;
            var matches = kind switch {
                StructureKind.AsmIdentifiers => names.Where(name => name.Contains(".asmid.")),
                StructureKind.AsmInstructions => names.Where(name => name.Contains(".asminxs.")),
                StructureKind.AsmSyntax => names.Where(name => name.Contains(".asmsyn.")),
                StructureKind.AsmBitFields => names.Where(name => name.Contains(".asmt.")),
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