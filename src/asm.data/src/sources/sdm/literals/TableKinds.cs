//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static SdmModels;

    partial struct SdmModels
    {
        public readonly struct TableKinds
        {
            public static SdmTableKind from(string name)
                => name switch {
                    OpCodes => SdmTableKind.OpCodes,
                    Encoding => SdmTableKind.Encoding,
                    BinaryFormat => SdmTableKind.BinaryFormat,
                    Intrinsics => SdmTableKind.Intrinsics,
                    _ => SdmTableKind.None
                };

            const string OpCodes = "OpCodes";

            const string Encoding = "Encoding";

            const string BinaryFormat = "BinaryFormat";

            const string Intrinsics = "Intrinsics";
        }
    }
}