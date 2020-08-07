//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
 
    public readonly struct PartFileKind
    {        
        public readonly StringRef Ext;
        
        [MethodImpl(Inline)]
        public PartFileKind(PartFileClass @class, string ext)
            => Ext = @ref(ext, (uint)@class);
        
        public PartFileClass Class 
        {
           [MethodImpl(Inline)]
           get => (PartFileClass)Ext.User;
        }        

        public MemoryAddress Address
        {
           [MethodImpl(Inline)]
           get => Ext.Address;
        }                
    }
}