//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Seed;    
    using static MetadataRecords;
    using static Control;
    
    partial class MetadataRead
    {        
        [MethodImpl(Inline)]
        internal static Span<T> alloc<T>(int count)
            => new T[count];

        [MethodImpl(Inline)]
        internal static string ReadEnum<E>(E value) 
            where E : unmanaged, Enum
                => value.ToString();

        internal static string PaddedHex(int src)
            => src.FormatHex(zpad:true, specifier:true, prespec:false);


        internal static TableIndex? ReadTableIndex(Handle handle)
        {
            if(MetadataTokens.TryGetTableIndex(handle.Kind, out var table))
                return table;         
            else
                return null;
        }

        internal static string Token(in ReaderState state, Handle handle, bool displayTable = true)
        {
            if (handle.IsNil)
                return "null";

            var table = ReadTableIndex(handle);
            var token = state.Reader.GetToken(handle);
            var tokenFmt = PaddedHex(token);
            if (displayTable && table != null)
                return $"{tokenFmt} | {table}";
            else
                return tokenFmt;
        }

    }
}