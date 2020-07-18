//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;
    using System.IO;
    using System.Linq;

    using static Konst;
    using static z;

    public readonly struct ResExtractor
    {
        readonly Assembly Source;

        [MethodImpl(Inline)]
        public static ResExtractor Service(Assembly src = null)
            => new ResExtractor(src ?? Assembly.GetCallingAssembly());
        
        [MethodImpl(Inline)]
        public ResExtractor(Assembly src)
        {
            Source = src;
        }

        public Option<string> ExtractText(string name)
        {
            try
            {
                using var stream = Source.GetManifestResourceStream(name);
                using var reader = new StreamReader(stream);
                return reader.ReadToEnd();
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<string>();
            }
        }

        public Option<string[]> ExtractTextLines(string name)
        {
            try
            {
                var dst = z.list<string>();
                using var stream = Source.GetManifestResourceStream(name);
                using var reader = new StreamReader(stream);
                while(!reader.EndOfStream)
                    dst.Add(reader.ReadLine());
                return dst.ToArray();
                
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<string[]>();
            }
        }

        public ParseResult<AppResourceDoc> ExtractDocument(string name)
        {
            using var stream = Source.GetManifestResourceStream(name);
            using var reader = new StreamReader(stream);
            return TextDocParser.parse(reader).TryMap(doc => new AppResourceDoc(name,doc));            
        }

        public ParseResult<AppResourceDoc> ExtractDocument(FileName name)
            => ExtractDocument(name.Name);
        
        public string[] ResourceNames
            => Source.GetManifestResourceNames();
        
        public AppResource Extract(Func<string,bool> match)
        {
            var name = ResourceNames.FirstOrDefault(match);
            if(text.blank(name))
                return AppResource.Empty;

            using var stream = Source.GetManifestResourceStream(name);
            using var reader = new StreamReader(stream);
            return new AppResource(name, reader.ReadToEnd());                    
        }
    }
}