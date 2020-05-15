//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Seed;
    using static Memories;
    
    public interface IMachineWorkflow : IMachineService
    {    

        void Process(PartInstructions src);

        void Render(PartInstructions src);
    }
}