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

         public ResDescriptor InstrinsicXml() => Asset("intel-intrinsics.xml");

         public ResDescriptor AsmDbInstructions() => Asset("asmdb.instructions.csv");

         public ResDescriptor AsmDbOperands() => Asset("asmdb.operands.csv");

         public ResDescriptor MsvcIntrinsicsX64() => Asset("msvc-intrinsics-x64");
    }
}