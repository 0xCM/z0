//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.IO;

    using static Seed;

    public readonly struct ResExtractor
    {
        [MethodImpl(Inline)]
        public static ResExtractor Service(Assembly src = null)
            => new ResExtractor(src ?? Assembly.GetExecutingAssembly());
        
        readonly Assembly Source;

        [MethodImpl(Inline)]
        public ResExtractor(Assembly src)
        {
            Source = src;
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