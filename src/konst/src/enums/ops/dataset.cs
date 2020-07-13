//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static z;

    partial class Enums
    {
        public static EnumInfo<E,T>[] describe<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dataset = Enums.dataset<E,T>();
            return describe<E,T>(dataset, new EnumInfo<E,T>[dataset.EntryCount]);
        }

        public static EnumInfo<E,T>[] describe<E,T>(EnumDataset<E,T> dataset, EnumInfo<E,T>[] buffer)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = span(buffer);
            for(var i=0u; i<dst.Length; i++)
            {
                var entry = dataset[(int)i];
                seek(dst,i) = EnumInfo.define(entry.Token, entry.Index, entry.Name, entry.Literal, entry.Scalar);
            }
            return buffer;
        }        

        public static EnumDataset dataset(Type @enum)
        {            
            var src = CreateIndex(@enum);
            var count = src.Length;
            var token = MetadataToken.From(@enum);
            var datatype = kind(@enum);
            var description = string.Empty;
            var enumData = UserMetadata.Empty;
            var indices = sys.alloc<int>(count);
            var names = sys.alloc<string>(count);
            var literals = sys.alloc<Enum>(count);
            var numeric = sys.alloc<variant>(count);
            var descriptions = sys.alloc<string>(count);
            var userData = sys.alloc<UserMetadata>(count);
            var tokens = sys.alloc<MetadataToken>(count);

            var dst = new EnumDataset(token, description,  UserMetadata.Empty, datatype, 
                tokens, indices,  names, literals, numeric, descriptions, userData);
            
            for(var i=0; i<count; i++)
            {
                indices[i] = src[i].Index;
                names[i] = src[i].Identifier;
                literals[i] = src[i].LiteralValue;
                numeric[i] = scalar(src[i].LiteralValue);
                tokens[i] = src[i].Token;
            }

            return dst;
        }    

        public static EnumDataset<E,T> dataset<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {            
            var src = LiteralSequence<E,T>();
            var count = src.Length;
            var token = MetadataToken.From<E>();
            var datatype = kind<E>();
            var description = string.Empty;
            var enumData = UserMetadata.Empty;
            var indices = sys.alloc<int>(count);
            var names = sys.alloc<string>(count);
            var literals = sys.alloc<E>(count);
            var numeric = sys.alloc<T>(count);
            var descriptions = sys.alloc<string>(count);
            var userData = sys.alloc<UserMetadata>(count);
            var tokens = sys.alloc<MetadataToken>(count);

            var dst = new EnumDataset<E,T>(token, description,  UserMetadata.Empty, datatype, 
                tokens, indices,  names, literals, numeric, descriptions, userData);
            
            for(var i=0; i<count; i++)
            {
                indices[i] = src[i].Index;
                names[i] = src[i].Identifier;
                literals[i] = src[i].LiteralValue;
                numeric[i] = src[i].NumericValue;
                userData[i] = src[i].UserData;
                descriptions[i] = src[i].Description;
                tokens[i] = src[i].Token;
            }

            return dst;
        }    
    }
}