//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPartRecord : IRecord
    {
        string Format(char delimiter);  

        string ITabular.DelimitedText(char delimiter) 
            => Format(delimiter);

        IPartRecordSpec Kind {get;}
    }
    
    public interface IPartRecord<K> : IPartRecord
        where K : unmanaged, IPartRecordSpec
    {
        new K Kind => default;
        
        IPartRecordSpec IPartRecord.Kind 
            => Kind;
    }
    
    public interface IPartRecord<F,K> : IPartRecord<K>
        where F : struct, IPartRecord<F,K>
        where K : unmanaged, IPartRecordSpec
    {
        
    }

    public interface IPartRecord<F,K,I> : IPartRecord<F,K>
        where F : struct, IPartRecord<F,K,I>
        where I : unmanaged, Enum
        where K : unmanaged, IPartRecordSpec
    {
        
    }    
}