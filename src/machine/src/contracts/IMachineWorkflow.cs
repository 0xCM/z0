//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;
        
    public interface IMachineWorkflow : IMachineService
    {    
        void Process(PartInstructions src);

        void Render(PartInstructions src);
    }
}