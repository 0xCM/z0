//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Parts;

    static class PartRunner
    {
        public static void RunParts(params string[] args)
        {
            // BitsTest.RunPart(args);
            // BitSvcTest.RunPart(args);
            // DynopsTest.RunPart(args);
            // GMathTest.RunPart(args);
            // GVecTest.RunPart(args);
            // IdentityTest.RunPart(args);
            // LogixTest.RunPart(args);   
            // MachinesTest.RunPart(args);         
            // MathSvcTest.RunPart(args);      
            // NatsTest.RunPart(args);      
            // MemoriesTest.RunPart(args);
            // NumericTest.RunPart(args);
            // PermuteTest.RunPart(args);
            // TextualTest.RunPart(args);

            NatsTest.RunPart(args);      

        }
    }
}