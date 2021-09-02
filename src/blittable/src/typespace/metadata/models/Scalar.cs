//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types.metadata
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Z0.Root;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct Scalar
    {
        public ScalarKind Kind;

        public uint StorageSize;

        public uint DataWidth;

        [MethodImpl(Inline)]
        public Scalar(ScalarKind kind, uint s, uint w)
        {
            Kind = kind;
            StorageSize = s;
            DataWidth = w;
        }
    }
}