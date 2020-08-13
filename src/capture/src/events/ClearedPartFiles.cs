//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static FormatPatterns;

    using static z;

    public readonly struct ClearedPartFiles : IWfEvent<ClearedPartFiles>
    {            
        const string ItemPattern = "{0} file {1} Deleted";
        
        public WfEventId EventId {get;}
        
        public readonly KeyedValues<PartId,FilePath[]> Files;

        [MethodImpl(Inline)]
        public ClearedPartFiles(KeyedValues<PartId,FilePath[]> files)
        {
            Files = files;
            EventId = WfEventId.define(nameof(ClearedPartFiles));
        }

        ReadOnlySpan<string> Descriptions
        {
            get 
            {
                var totalFileCount = Files.Count;
                var dst = z.span<string>(totalFileCount);
                for(var i=0u; i<totalFileCount; i++)
                {
                    ref readonly var next = ref Files[i];
                    var part = next.Key;
                    var partFiles =  span(next.Value);
                    var partFileCount = partFiles.Length;                    
                    var partName = part.Format();

                    for(var j = 0u; j<partFileCount; j++)
                    {
                        ref readonly var file = ref skip(partFiles,j);
                        seek(dst, i) = text.format(ItemPattern, partName, file);
                    }                    
                }
                return dst;
            }
        }
        
        public string Format()                        
            => text.format(PSx3, nameof(ClearedPartFiles), Eol, text.join(Eol, Descriptions));
    }    
}