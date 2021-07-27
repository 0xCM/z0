//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct AsmTableScopes
    {
        public static Scope Sdm => "intel.sdm";

        public static Scope SdmInstructions => "sdm.instructions";

        public static Scope IntelXed => "intel.xed";

        public static Scope Nasm => "nasm";
    }
}