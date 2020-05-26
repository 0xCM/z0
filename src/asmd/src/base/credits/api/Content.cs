//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static CreditTypes;

    using D = CreditTypes.DocFieldDelimiter;
    using F = CreditTypes.DocField;
    using Entity = ContentRef;

    partial class Credits 
    {
        [Op, MethodImpl(Inline)]
        public static Entity content(DocRef src)
            => (ushort)(((ulong)F.Content & (ulong)src) >> (int)D.Content);

        [Op, MethodImpl(Inline)]
        public static DocRef content(Entity src)
            => (ulong)src << (byte)D.Content;

        [Op, MethodImpl(Inline)]
        public static Entity table(ContentNumber n0, ContentNumber n1 = default, ContentNumber n2 = default)
        {
            var l0 = (ushort)n0;
            var l1 = (ushort)((byte)n1 << (byte)ContentLevel.L1);
            var l2 = (ushort)((byte)n2 << (byte)ContentLevel.L2);
            var ct = (ushort)((byte)ContentType.Table << (byte)ContentLevel.Type);
            return math.or(l0,l1,l2,ct);
            // var l0 = genum.sll(n0, ContentLevel.L0, z8, z16);
            // var l1 = genum.sll(n1, ContentLevel.L1, z8, z16);
            // var l2 = genum.sll(n2, ContentLevel.L2, z8, z16);
            // var ct = genum.sll(ContentType.Table, ContentLevel.Type, z8, z16);
            // return math.or(l0, l1, l2, ct);            
        }

        [Op, MethodImpl(Inline)]
        public static ContentNumber number(Entity src, N0 level)
        {
            var isolated = (ushort)((ushort)(ContentField.L0) & (ushort)src);
            return (ContentNumber)(isolated >> (byte)ContentLevel.L0);                        
        }

        [Op, MethodImpl(Inline)]
        public static ContentNumber number(Entity src, N1 level)
        {
            var isolated = (ushort)((ushort)(ContentField.L1) & (ushort)src);
            return (ContentNumber)(isolated >> (byte)ContentLevel.L1);                        
        }

        [Op, MethodImpl(Inline)]
        public static ContentNumber number(Entity src, N2 level)
        {
            var isolated = (ushort)((ushort)(ContentField.L2) & (ushort)src);
            return (ContentNumber)(isolated >> (byte)ContentLevel.L2);                        
        }

        [Op, MethodImpl(Inline)]
        public static ContentType type(Entity src)
        {
            var isolated = (ushort)((ushort)(ContentField.Type) & (ushort)src);
            var value = isolated >> (byte)ContentLevel.Type;
            return (ContentType)value;
        }

        public static string format(Entity src)
        {
            if(src.IsNonEmpty)
            {
                var l0 = (byte)src.Level0;            
                var l1 = (byte)src.Level1;
                var l2 = (byte)src.Level2;
                return text.concat(src.ContentType, ':', l0, '.', l1, '.', l2);
            }
            else
                return string.Empty;
        }

        const char DotSep = (char)SymNotKind.Dot;
        
        const char UriSep = (char)SymNotKind.FSlash;       
    }
}