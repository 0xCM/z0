//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata.Ecma335;
    using System.IO;

    using static Konst;
    using static z;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using I = System.Reflection.Metadata.Ecma335.TableIndex;

    [Free, ApiHost]
    public partial class PeTableReader : IDisposable
    {
        [MethodImpl(Inline)]
        internal static ReadOnlySpan<R> empty<R>()
            => ReadOnlySpan<R>.Empty;

        readonly ReaderState State;

        [MethodImpl(Inline)]
        internal PeTableReader(ReaderState src)
            => State = src;

        public void Dispose()
            => State.Dispose();

        [MethodImpl(Inline), Op]
        public static string ustring(MetadataReader reader, UserStringHandle handle)
            => reader.GetUserString(handle);

        internal static TableIndex? index(Handle handle)
        {
            if(MetadataTokens.TryGetTableIndex(handle.Kind, out var table))
                return table;
            else
                return null;
        }

        public static ConstantHandle ConstantHandle(uint row)
            => MetadataTokens.ConstantHandle((int)row);

        [MethodImpl(Inline), Op]
        public static int ConstantCount(in ReaderState state)
            => state.Reader.GetTableRowCount(I.Constant);
    }
}