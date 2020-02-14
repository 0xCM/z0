// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    readonly struct BitGridIdentity : ITypeIdentityProvider
    {        
        public TypeIdentity DefineIdentity(Type src)
        {
            var kind = src.GridKind().ValueOrDefault();
            if(!kind.IsSome())
                return TypeIdentity.Empty;
            
            if(src.IsOpenGeneric())
                return TypeIdentity.Define(kind.Indicator());
            
            var closures = src.GridClosures();
            if(!closures.IsSome())
                return TypeIdentity.Empty;
            
            var segsep = IDI.SegSep.ToString();
            var count = closures.NonEmptyCount();

            if(count == 1)
                return TypeIdentity.Define(concat(kind.Indicator(), closures.C.Format()));
            else if(count == 3)
                return TypeIdentity.Define(concat(
                        kind.Indicator(), segsep, 
                        kind.Width().Format(), segsep, 
                        closures.A.Format(), segsep,
                        closures.B.Format(), segsep,
                        closures.C.Format()
                        ));
            else 
                return TypeIdentity.Empty;            
        }
    }

}