// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;

    readonly struct BitMatrixIdentityProvider : ITypeIdentityProvider
    {
        public Moniker DefineIdentity(Type src)
        {
            var id = string.Empty;
            var t = src.EffectiveType();

            var kind = NumericKind.None;
            if(t.IsConstructedGenericType && t.GetGenericTypeDefinition() ==typeof(BitMatrix<>))
                kind = t.GetGenericArguments().Single().NumericKind();                
            else if(t.ContainsGenericParameters && t.GenericDefinition() == typeof(BitMatrix<>))
                id = $"bm[T]";
            else
            {
                if(t == typeof(BitMatrix8))
                    kind = NumericKind.U8;
                else if(t == typeof(BitMatrix16))
                    kind = NumericKind.U16;
                else if(t == typeof(BitMatrix32))
                    kind = NumericKind.U32;
                else if(t == typeof(BitMatrix64))
                    kind = NumericKind.U64;
            }

            if(kind.IsSome())
                id = concat("bm", kind.Width().ToString(), Moniker.SegSep, NumericType.signature(kind));
            
            return Moniker.Parse(id);            
        }
    }

}