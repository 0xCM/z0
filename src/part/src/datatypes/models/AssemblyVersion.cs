//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    [Datatype, StructLayout(LayoutKind.Sequential)]
    public struct AssemblyVersion
    {
        public ushort Major;

        public ushort Minor;

        public ushort Build;

        public ushort Revision;

        [MethodImpl(Inline)]
        public AssemblyVersion(ushort a, ushort b, ushort c, ushort d)
        {
            Major = a;
            Minor = b;
            Build = c;
            Revision = d;
        }
    }
}
