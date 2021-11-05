//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct ScalarType
    {
        public readonly IndicatorKind Kind;

        public readonly uint StorageSize;

        public readonly uint DataWidth;

        [MethodImpl(Inline)]
        public ScalarType(IndicatorKind kind, uint s, uint w)
        {
            Kind = kind;
            StorageSize = s;
            DataWidth = w;
        }
    }
}
