//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static Part;

    [Datatype, StructLayout(LayoutKind.Sequential)]
    public readonly struct ClrAssemblyVersion
    {
        public ushort Major {get;}

        public ushort Minor {get;}

        public ushort Build {get;}

        public ushort Revision {get;}

        [MethodImpl(Inline)]
        public ClrAssemblyVersion(ushort a, ushort b, ushort c, ushort d)
        {
            Major = a;
            Minor = b;
            Build = c;
            Revision = d;
        }

        [MethodImpl(Inline)]
        public ClrAssemblyVersion(int a, int b, int c, int d)
        {
            Major = (ushort)a;
            Minor = (ushort)b;
            Build = (ushort)c;
            Revision = (ushort)d;
        }
    }
}
