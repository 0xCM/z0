//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct IntelSdm
    {
        public readonly struct TableKinds
        {
            public static TableKind from(string name)
                => name switch {
                    OpCodes => TableKind.OpCodes,
                    Encoding => TableKind.Encoding,
                    BinaryFormat => TableKind.BinaryFormat,
                    Intrinsics => TableKind.Intrinsics,
                    _ => TableKind.None
                };

            const string OpCodes = "OpCodes";

            const string Encoding = "Encoding";

            const string BinaryFormat = "BinaryFormat";

            const string Intrinsics = "Intrinsics";
        }
    }
}