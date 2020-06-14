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

    using static Seed;
    using static Memories;

    public readonly struct ResExtractor
    {
        [MethodImpl(Inline)]
        public static ResExtractor Service(Assembly src = null)
            => new ResExtractor(src ?? Assembly.GetCallingAssembly());
        
        readonly Assembly Source;

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
                var dst = Control.list<string>();
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

        public Option<AppResourceDoc> ExtractDocument(string name)
        {
            using var stream = Source.GetManifestResourceStream(name);
            using var reader = new StreamReader(stream);
            return reader.ReadTextDoc().TryMap(doc => new AppResourceDoc(name,doc));            
        }

        public Option<AppResourceDoc> ExtractDocument(FileName name)
            => ExtractDocument(name.Name);
        
        public string[] ResourceNames
            => Source.GetManifestResourceNames();
    }
}