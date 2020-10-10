//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CliHandleToken
    {
        public readonly Handle Handle;

        public readonly ClrArtifactKey Token;

        public readonly TableIndex Source;

        [MethodImpl(Inline)]
        public CliHandleToken(Handle handle, ClrArtifactKey token, TableIndex src)
        {
            Handle = handle;
            Token = token;
            Source = src;
        }

        public static CliHandleToken Empty
            => default;
    }
}