//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Root;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free, ApiHost]
    public partial class PeTableReader : IDisposable
    {
        [MethodImpl(Inline)]
        internal static ReadOnlySpan<R> empty<R>()
            => ReadOnlySpan<R>.Empty;

        readonly PeStream Stream;

        [MethodImpl(Inline)]
        internal PeTableReader(PeStream src)
            => Stream = src;

        public void Dispose()
            => Stream.Dispose();

        public static string UserString(MetadataReader reader, UserStringHandle handle)
            => reader.GetUserString(handle);

        internal static TableIndex? index(Handle handle)
        {
            if(MetadataTokens.TryGetTableIndex(handle.Kind, out var table))
                return table;
            else
                return null;
        }
    }
}