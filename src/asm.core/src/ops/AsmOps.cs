//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static AsmOperands;
    using static core;



    [ApiHost]
    public partial class AsmOps
    {
        public struct ROL8r1
        {
            public AsmId Id => AsmId.ROL8r1;
        }
    }
    /*
        ROL8r1	= 2593,
        ROR16r1	= 2599,
        ROR32r1	= 2605,
        ROL16m1	= 2572,
        ROL64r1	= 2587,
        ROL16mCL	= 2573,
        ROL16mi	= 2574,
        ROL16r1	= 2575,
        ROL16rCL	= 2576,
        ROL16ri	= 2577,
        ROL32m1	= 2578,
        ROL32mCL	= 2579,
        ROL32mi	= 2580,
        ROL32r1	= 2581,
        ROL32rCL	= 2582,
        ROL32ri	= 2583,
        ROL64m1	= 2584,
        ROL64mCL	= 2585,
        ROL64mi	= 2586,
        ROL64rCL	= 2588,
        ROL64ri	= 2589,
        ROL8m1	= 2590,
        ROL8mCL	= 2591,
        ROL8mi	= 2592,
        ROL8rCL	= 2594,
        ROL8ri	= 2595,
        ROR16m1	= 2596,
        ROR16mCL	= 2597,
        ROR16mi	= 2598,
        ROR16rCL	= 2600,
        ROR16ri	= 2601,
        ROR32m1	= 2602,
        ROR32mCL	= 2603,
        ROR32mi	= 2604,
        ROR32rCL	= 2606,
        ROR32ri	= 2607,
        ROR64m1	= 2608,
        ROR64mCL	= 2609,
        ROR64mi	= 2610,
        ROR64r1	= 2611,
        ROR64rCL	= 2612,
        ROR64ri	= 2613,
        ROR8m1	= 2614,
        ROR8mCL	= 2615,
        ROR8mi	= 2616,
        ROR8r1	= 2617,
        ROR8rCL	= 2618,
        ROR8ri	= 2619,
        RORX32mi	= 2620,
        RORX32ri	= 2621,
        RORX64mi	= 2622,
        RORX64ri	= 2623,

    */
}