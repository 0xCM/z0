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
        /// <summary>
        /// Creates an enumeration dataset predicated on supplied type parameters
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The refined primitive type</typeparam>
        public static EnumDataset<E,T> dataset<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var src = LiteralSequence<E,T>();
            var count = src.Length;
            var token = CliKey.from<E>();
            var datatype = kind<E>();
            var description = string.Empty;
            var indices = sys.alloc<uint>(count);
            var names = sys.alloc<string>(count);
            var literals = sys.alloc<E>(count);
            var numeric = sys.alloc<T>(count);
            var descriptions = sys.alloc<string>(count);
            var tokens = sys.alloc<CliKey>(count);
            var dst = new EnumDataset<E,T>(token, description, datatype, tokens, indices,  names, literals, numeric, descriptions);
            for(var i=0; i<count; i++)
            {
                indices[i] = src[i].Position;
                names[i] = src[i].Name;
                literals[i] = src[i].LiteralValue;
                numeric[i] = src[i].PrimalValue;
                descriptions[i] = src[i].Description;
                tokens[i] = src[i].Token;
            }

            return dst;
        }
    }
}