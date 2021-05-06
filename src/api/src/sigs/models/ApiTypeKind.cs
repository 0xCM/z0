//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ApiSigs
    {
        public enum ApiTypKind : byte
        {
            None = 0,

            SystemPrimitive,

            Enum,

            PrimalAdapter,

            CpuVector,

            Span,

            BlockedSpan,

            DataCell,

        }
    }
}