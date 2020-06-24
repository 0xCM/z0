//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPartRecord : IRecord
    {
        string Format(char delimiter)
            => string.Empty;
            
        string ITabular.DelimitedText(char delimiter) 
            => string.Empty;

        PartRecordKind Kind {get;}
                
    }
    
    public interface IPartRecord<K> : IPartRecord
        where K : unmanaged, IPartRecordSpec
    {

    }
    
    public interface IPartRecord<F,R> : ITabular<F,R>, IPartRecord
        where R : struct, IPartRecord<F,R>
        where F : unmanaged, Enum
    {
        
    }

    public interface IPartRecord<F,P,K> : ITabular<F,P>
        where P : struct, IPartRecord<F,P,K>
        where K : unmanaged, IPartRecordSpec
        where F : unmanaged, Enum
    {
        
    }    
}