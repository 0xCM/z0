// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Runtime.CompilerServices;
    
    readonly struct BitGridIdentityProvider : ITypeIdentityProvider
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
            var args = closures.NonEmptyCount();

            if(args == 1)
                return TypeIdentity.Define(text.concat(kind.Indicator(), closures.T.Format()));
            else if(args == 3)
                return TypeIdentity.Define(text.concat(
                        kind.Indicator(), segsep, 
                        kind.Width().Format(), segsep, 
                        closures.M.ToString(), segsep,
                        closures.N.ToString(), segsep,
                        closures.T.Format()
                        ));
            else 
                return TypeIdentity.Empty;            
        }
    }
}