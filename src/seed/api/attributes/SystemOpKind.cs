//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = SystemOpKind;

    public class SystemOpKindAttribute : OpKindAttribute
    {
        public SystemOpKindAttribute(K kind) 
            : base(kind)
        {
            Kind = kind;
        }

        public K Kind {get;}
    }

    public class LoadAttribute : SystemOpKindAttribute    
    {
        public LoadAttribute()
            : base(K.Load)
        {

        }
    }

    public class StoreAttribute : SystemOpKindAttribute    
    {
        public StoreAttribute()
            : base(K.Store)
        {
            
        }
    }

    public class AllocAttribute : SystemOpKindAttribute    
    {
        public AllocAttribute()
            : base(K.Alloc)
        {
            
        }
    }

    public class InitAttribute : SystemOpKindAttribute    
    {
        public InitAttribute()
            : base(K.Init)
        {
            
        }
    }    
}