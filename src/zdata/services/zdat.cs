//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct zdat
    {
        /// <summary>
        /// Returns the identifiers for all embedded content
        /// </summary>
        public static string[] ContentNames
            => Extractor.ResourceNames;

        /// <summary>
        /// Returns supported content kinds
        /// </summary>
        public static ContentKind[] ContentClasses
            => Enums.literals<ContentKind>().Where(x => x != 0).OrderBy(x => x.Format());

        /// <summary>
        /// Returns supported content kinds
        /// </summary>
        public static StructureKind[] StructuredClasses
            => Enums.literals<StructureKind>().Where(x => x != 0).OrderBy(x => x.Format());
        
        public static IEnumerable<ContentLibEntry> Catalog
        {
            get
            {
                foreach(var (k,r) in Content)
                {
                   yield return new ContentLibEntry((ContentKind)k, StructureKind.None, (uint)r.Content.Length, r.Name);

                }
               foreach(var (k,r) in Structured)                 
                   yield return new ContentLibEntry((ContentKind)k, k, (uint)r.RowCount, r.Name);
            }
        }

        public static ReadOnlySpan<SystemImageSymbol> SystemImages
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
        public static IEnumerable<Paired<ContentKind,AppResource>> Content
        {
            get
            {
                foreach(var k in ContentClasses)
                    foreach(var res in match(k))
                        yield return (k,res);
            }
        }        

        /// <summary>
        /// Enumerates all structureded content
        /// </summary>
        public static IEnumerable<Paired<StructureKind,AppResourceDoc>> Structured
        {
            get
            {
                foreach(var k in StructuredClasses)
                    foreach(var doc in match(k))
                        yield return (k,doc);
            }
        }    

        /// <summary>
        /// Searches for embedded content with a matching identifier and, if found,
        /// returns the first matching resource; otherwise returns an empty resource
        /// </summary>
        /// <param name="match">The resource identifier to match</param>
        public static AppResource content(string match)
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
        /// Searches for an embedded document with a matching identifier and, if found,
        /// returns the first match; otherwise returns an empty document
        /// </summary>
        /// <param name="match">The resource identifier to match</param>
        public static AppResourceDoc structured(string match)
            => Extractor.MatcDocument(match);

        /// <summary>
        /// Enumerates embedded documents with matching kind
        /// </summary>
        /// <param name="kind">The kind to match</param>
        public static IEnumerable<AppResourceDoc> match(StructureKind kind)
        {
            var svc = Extractor;
            var names = svc.ResourceNames;
            var matches = kind switch {
                StructureKind.AsmId => names.Where(name => name.Contains(".asmid.")),
                StructureKind.AsmInxs => names.Where(name => name.Contains(".asminxs.")),
                StructureKind.AsmSyn => names.Where(name => name.Contains(".asmsyn.")),
                StructureKind.AsmT => names.Where(name => name.Contains(".asmt.")),
                StructureKind.Env => names.Where(name => name.Contains(".env.")),
                StructureKind.Help => names.Where(name => name.Contains(".help.")),
                StructureKind.PeFormat => names.Where(name => name.Contains(".peformat.")),
                    _ => sys.empty<string>(),
            };
            
            foreach(var match in matches)
            {
                var doc = svc.ExtractDocument(match);
                if(doc.Succeeded)
                    yield return doc.Value;
            }
        }

        /// <summary>
        /// Enumerates embedded content with matching kind
        /// </summary>
        /// <param name="kind">The kind to match</param>
        public static IEnumerable<AppResource> match(ContentKind kind)
        {
            var svc = Extractor;
            var names = svc.ResourceNames;
            var matches = kind switch {
                ContentKind.AsmAlg => names.Where(name => name.Contains(".asmalg.")),
                ContentKind.AsmId => names.Where(name => name.Contains(".asmid.")),
                ContentKind.AsmInxs => names.Where(name => name.Contains(".asminxs.")),
                ContentKind.AsmSyn => names.Where(name => name.Contains(".asmsyn.")),
                ContentKind.AsmT => names.Where(name => name.Contains(".asmt.")),
                ContentKind.Env => names.Where(name => name.Contains(".env.")),
                ContentKind.Help => names.Where(name => name.Contains(".help.")),
                ContentKind.PeFormat => names.Where(name => name.Contains(".peformat.")),
                ContentKind.Tools => names.Where(name => name.Contains(".tools.")),
                ContentKind.Xed => names.Where(name => name.Contains(".xed.")),
                ContentKind.Xml => names.Where(name => name.Contains(".xml.")),

                    _ => sys.empty<string>(),
            };
            
            foreach(var match in matches)
                yield return svc.Extract(match);
        }

        static ResExtractor Extractor
            => ResExtractor.Service(typeof(zdat).Assembly);
    }

    partial class XTend
    {
        public static string Format(this ContentKind src)
            => src.ToString().ToLower();

        public static string Format(this StructureKind src)
            => src.ToString().ToLower();
    }
}