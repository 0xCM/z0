//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct PartIndexer : TPartIndexer
    {
        public static TPartIndexer Fatory => default(PartIndexer);
    }

    public interface TPartIndexer 
    {
        IPartIdParser Parser 
            => PartIdParser.Service;   

        IPartIndexBuilder IndexBuiler 
            => PartIndexBuilder.Service;     
    }
}