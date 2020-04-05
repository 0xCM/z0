//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class SystemOpKindAttribute : OpAttribute
    {
        public SystemOpKindAttribute(SystemOpKind kind) 
        {
            Kind = kind;
        }

        public SystemOpKind Kind {get;}
    }

    public class LoadAttribute : SystemOpKindAttribute    
    {
        public LoadAttribute()
            : base(SystemOpKind.Load)
        {

        }
    }

    public class StoreAttribute : SystemOpKindAttribute    
    {
        public StoreAttribute()
            : base(SystemOpKind.Store)
        {
            
        }
    }

    public class AllocAttribute : SystemOpKindAttribute    
    {
        public AllocAttribute()
            : base(SystemOpKind.Alloc)
        {
            
        }
    }
}