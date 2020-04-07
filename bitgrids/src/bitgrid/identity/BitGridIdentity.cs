// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Runtime.CompilerServices;
    
    readonly struct BitGridIdentity : ITypeIdentityProvider
    {        
        public TypeIdentity Identify(Type src)
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
                return TypeIdentity.Define(text.concat(kind.Indicator(), closures.Third.Format()));
            else if(count == 3)
                return TypeIdentity.Define(text.concat(
                        kind.Indicator(), segsep, 
                        kind.Width().Format(), segsep, 
                        closures.First.Format(), segsep,
                        closures.Second.Format(), segsep,
                        closures.Third.Format()
                        ));
            else 
                return TypeIdentity.Empty;            
        }
    }
}