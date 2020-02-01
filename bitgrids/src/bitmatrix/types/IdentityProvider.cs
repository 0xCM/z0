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
        public Option<Moniker> DefineIdentity(Type src)
        {
            const string prefix = "bm";
            
            var t = src.EffectiveType();
            if(t.ContainsGenericParameters && t.GenericDefinition() == typeof(BitMatrix<>))
                return Moniker.Parse($"{prefix}[T]");
            
            if(t.IsConstructedGenericType && t.GetGenericTypeDefinition() ==typeof(BitMatrix<>))
            {
                var kind = t.GetGenericArguments().Single().NumericKind();
                return Moniker.Parse(concat(prefix, kind.Width().ToString(), Moniker.SegSep, NumericType.signature(kind)));                
            }
            else
            {
                var width = FixedWidth.None;
                var kind = NumericKind.None;
                if(t == typeof(BitMatrix4))
                {
                    kind = NumericKind.U8;
                    width = FixedWidth.W4;
                }
                else if(t == typeof(BitMatrix8))
                {
                    kind = NumericKind.U8;
                    width = FixedWidth.W8;
                }
                else if(t == typeof(BitMatrix16))
                {
                    kind = NumericKind.U16;
                    width = FixedWidth.W16;
                }
                else if(t == typeof(BitMatrix32))
                {
                    kind = NumericKind.U32;
                    width = FixedWidth.W32;
                }
                else if(t == typeof(BitMatrix64))
                {
                    kind = NumericKind.U64;
                    width = FixedWidth.W64;
                }

                if(kind.IsSome() && width.IsSome())
                    return Moniker.Parse(concat(prefix, width.Format(), Moniker.SegSep, NumericType.signature(kind)));
            }

            return Moniker.Parse($"{prefix}err");                        
                  
        }
    }

}