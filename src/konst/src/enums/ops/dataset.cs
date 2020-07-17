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
        public static EnumDataset dataset(Type @enum)
        {            
            var src = Enums.index(@enum);
            var index = span(src.Content);
            var count = src.Length;
            var token = ArtifactIdentity.From(@enum);
            var datatype = kind(@enum);
            var description = string.Empty;
            var enumData = UserMetadata.Empty;
            var indices = sys.alloc<uint>(count);
            var names = sys.alloc<string>(count);
            var numeric = sys.alloc<variant>(count);
            var descriptions = sys.alloc<string>(count);
            var userData = sys.alloc<UserMetadata>(count);
            var tokens = sys.alloc<ArtifactIdentity>(count);

            var dst = new EnumDataset(token, description,  UserMetadata.Empty, datatype, 
                tokens, indices,  names, numeric, descriptions, userData);
            
            for(var i=0u; i<count; i++)
            {
                ref readonly var entry = ref skip(index,i);
                indices[i] = entry.Position;
                names[i] = entry.Name;
                numeric[i] = entry.ScalarValue;
                tokens[i] = entry.Id;
            }

            return dst;
        }    

        public static EnumDataset<E,T> dataset<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {            
            var src = LiteralSequence<E,T>();
            var count = src.Length;
            var token = ArtifactIdentity.From<E>();
            var datatype = kind<E>();
            var description = string.Empty;
            var enumData = UserMetadata.Empty;
            var indices = sys.alloc<uint>(count);
            var names = sys.alloc<string>(count);
            var literals = sys.alloc<E>(count);
            var numeric = sys.alloc<T>(count);
            var descriptions = sys.alloc<string>(count);
            var userData = sys.alloc<UserMetadata>(count);
            var tokens = sys.alloc<ArtifactIdentity>(count);

            var dst = new EnumDataset<E,T>(token, description,  UserMetadata.Empty, datatype, 
                tokens, indices,  names, literals, numeric, descriptions, userData);
            
            for(var i=0; i<count; i++)
            {
                indices[i] = src[i].Position;
                names[i] = src[i].Name;
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