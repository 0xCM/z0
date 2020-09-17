//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static z;

    partial class Enums
    {
        /// <summary>
        /// Defines a useful representation of an enumeration literal
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type refined by the enum</typeparam>
        /// <typeparam name="A">The asci identifier type</typeparam>
        [MethodImpl(Inline)]
        public static EnumLiteralInfo<E,T> describe<E,T>(ArtifactIdentifier token, uint index, string identifier, E literal, T scalar)
            where E : unmanaged, Enum
            where T : unmanaged
                => new EnumLiteralInfo<E,T>(token, index, identifier, literal, scalar);

        public static EnumLiteralInfo<E,T>[] describe<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dataset = Enums.dataset<E,T>();
            return describe<E,T>(dataset, new EnumLiteralInfo<E,T>[dataset.EntryCount]);
        }

        public static EnumLiteralInfo<E,T>[] describe<E,T>(EnumDataset<E,T> dataset, EnumLiteralInfo<E,T>[] buffer)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = span(buffer);
            for(var i=0u; i<dst.Length; i++)
            {
                var entry = dataset[(int)i];
                seek(dst,i) = describe(entry.Id, entry.Index, entry.Name, entry.EnumValue, entry.ScalarValue);
            }
            return buffer;
        }

    }
}