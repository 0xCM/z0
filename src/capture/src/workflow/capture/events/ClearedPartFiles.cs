//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ClearedPartFiles : IAppEvent<ClearedPartFiles>
    {            
        const string MessagePattern = "{0} file {1} Deleted";

        public readonly KeyedValues<PartId,FilePath[]> Files;

        [MethodImpl(Inline)]
        public ClearedPartFiles(KeyedValues<PartId,FilePath[]> files)
            => Files = files;

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
                        seek(dst, i) = text.format(MessagePattern, partName, file);
                    }                    
                }
                return dst;
            }
        }
        
        public string Description                        
            => text.join(Eol, Descriptions);
    }    
}