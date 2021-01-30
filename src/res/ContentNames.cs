//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct ContentNames
    {
        public const string OpCodeSpecs = "OpCodeSpecs";

        public static ContentName IntelIntinsics => "intrinsics.xml";

        public static ContentName AsmCatalog => "AsmCatalog.csv";

        public static ContentName MsvcCompilerIntrinsicsX64 = "CompilerIntrinsics.MsvcX64.csv";

        public static ContentName MsvcCompilerIntrinsicsX86 = "CompilerIntrinsics.MsvcX86.csv";

        public static ContentName CilOpCodeMs = "CilOpCodeMs.csv";

        public static ContentName CilOpCodeWiki = "CilOpCodeWiki.csv";
    }
}