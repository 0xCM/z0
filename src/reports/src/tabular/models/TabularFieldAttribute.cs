//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    static class EnumReader
    {
        /// <summary>
        /// Reads a generic numeric value from a boxed enum
        /// </summary>
        /// <param name="e">The enum value to reinterpret</param>
        /// <typeparam name="V">The numeric value type</typeparam>
        [MethodImpl(Inline)]
        public static V numeric<V>(Enum e)
            where V : unmanaged
                => (V)Convert.ChangeType(e, e.GetTypeCode());
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class TabularFieldAttribute : Attribute
    {
        public string Name {get;}

        public int Index {get;}
        
        public int Width {get;}

        [MethodImpl(Inline)]
        static T read<T>(Enum value)
            where T : unmanaged 
                => EnumReader.numeric<T>(value);
             
        public TabularFieldAttribute(object id)
        {
            var evalue = (Enum)id;
            var kind = evalue.GetType().GetEnumUnderlyingType().NumericKind();
            (Index, Width) = kind switch {
                NumericKind.I32 => ((short)read<int>(evalue),    (short)(read<int>(evalue) >> 16)),
                NumericKind.U32 => ((short)read<uint>(evalue),   (short)(read<uint>(evalue) >> 16)),
                NumericKind.U64 => ((short)read<ulong>(evalue),  (short)(read<ulong>(evalue) >> 32)),
                _ => ((short)0,(short)0),
            };

            Name = $"{evalue}";
        }
    }
}