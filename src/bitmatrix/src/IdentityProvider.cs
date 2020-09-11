// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    readonly struct BitMatrixIdentityProvider : ITypeIdentityProvider
    {
        public TypeIdentity Identify(Type src)
        {
            const string prefix = "bm";

            var t = src.EffectiveType();
            if(t.ContainsGenericParameters && t.GenericDefinition() == typeof(BitMatrix<>))
                return TypeIdentity.define($"{prefix}[T]");

            if(t.IsConstructedGenericType && t.GetGenericTypeDefinition() ==typeof(BitMatrix<>))
            {
                var kind = t.GetGenericArguments().Single().NumericKind();
                return TypeIdentity.define(text.concat(prefix, kind.Width().ToString(), IDI.SegSep, kind.Format()));
            }
            else
            {
                var width = CellWidth.None;
                var kind = NumericKind.None;
                if(t == typeof(BitMatrix4))
                {
                    kind = NumericKind.U8;
                    width = CellWidth.W4;
                }
                else if(t == typeof(BitMatrix8))
                {
                    kind = NumericKind.U8;
                    width = CellWidth.W8;
                }
                else if(t == typeof(BitMatrix16))
                {
                    kind = NumericKind.U16;
                    width = CellWidth.W16;
                }
                else if(t == typeof(BitMatrix32))
                {
                    kind = NumericKind.U32;
                    width = CellWidth.W32;
                }
                else if(t == typeof(BitMatrix64))
                {
                    kind = NumericKind.U64;
                    width = CellWidth.W64;
                }

                if(kind != 0 && width != 0)
                    return TypeIdentity.define(text.concat(prefix, width.Format(), IDI.SegSep, kind.Format()));
            }

            return TypeIdentity.define($"{prefix}err");
        }
    }
}