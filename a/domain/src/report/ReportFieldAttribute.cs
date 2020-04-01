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
    public class ReportFieldAttribute : Attribute
    {
        public string Name {get;}

        public int? Index {get;}
        
        public int? Width {get;}

        public ReportFieldAttribute(object id)
        {
            var evalue = (Enum)id;
            var ivalue = EnumReader.numeric<ulong>(evalue);
            Name = $"{evalue}";
            Index = (int)ivalue;
            Width = (int)(ivalue >> 32);
        }
    }
}