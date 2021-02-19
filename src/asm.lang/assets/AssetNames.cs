//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class Assets : Assets<Assets>
    {
         public ResDescriptor AsmCatalog() => Asset("AsmCatalog.csv");

         public ResDescriptor AsmMnemonicInfo() => Asset("AsmMnemonicInfo.csv");

         public ResDescriptor IntelIntrinsicsData() => Asset("intel-intrinsics.xml");

         public ResDescriptor AsmJitOpCodes() => Asset("asmjit-opcodes.asm");

         public ResDescriptor MsvcIntrinsicsX64() => Asset("msvc-intrinsics-x64");
    }
}