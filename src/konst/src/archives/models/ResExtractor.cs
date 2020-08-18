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
        public ResExtractor(Assembly src)
            => Source = src;

        [MethodImpl(Inline)]
        public static ResExtractor Service(Assembly src = null)
            => new ResExtractor(src ?? Assembly.GetCallingAssembly());
        
        public ParseResult<AppResourceDoc> ExtractDocument(FileName name)
            => ExtractDocument(name.Name);
        
        public string[] ResourceNames
            => Source.GetManifestResourceNames();        
        
        public string MatchName(string match)
            => ResourceNames.Where(n => n.ToLower().Contains(match.ToLower())).FirstOrDefault(EmptyString);
        
        public ParseResult<AppResourceDoc> ExtractDocument(string name)
        {
            try
            {
                using var stream = Source.GetManifestResourceStream(name);
                using var reader = new StreamReader(stream);
                return TextDocParser.parse(reader).TryMap(doc => new AppResourceDoc(name,doc));            
            }
            catch(Exception e)
            {
                term.error(e);
            }
            
            return z.unparsed<AppResourceDoc>(name);
        }

        public AppResourceDoc MatchDocument(string doc)
        {
            try
            {
                var name = MatchName(doc);
                if(text.nonempty(name))
                {
                    using var stream = Source.GetManifestResourceStream(name);
                    using var reader = new StreamReader(stream);
                    var result = TextDocParser.parse(reader).TryMap(doc => new AppResourceDoc(name,doc));   
                    if(result.Succeeded)         
                        return result.Value;

                }
            }
            catch(Exception e)
            {
                term.error(e);
            }
            
            return AppResourceDoc.Empty;
        }

        public AppResource Extract(string name)
        {
            try
            {
                var match = MatchName(name);
                if(text.nonempty(match))
                {
                    using var stream = Source.GetManifestResourceStream(name);
                    using var reader = new StreamReader(stream);
                    return new AppResource(name, reader.ReadToEnd());                                    
                }
            }
            catch(Exception e)
            {
                term.error(e);
            }

            return AppResource.Empty;
        }

        public AppResource Extract(Func<string,bool> match)
        {
            try
            {
                var name = ResourceNames.FirstOrDefault(match);
                if(text.nonempty(name))
                {
                    using var stream = Source.GetManifestResourceStream(name);
                    using var reader = new StreamReader(stream);
                    return new AppResource(name, reader.ReadToEnd());
                }

            }
            catch(Exception e)
            {
                term.error(e);
            }

            return AppResource.Empty;
        }
    }
}