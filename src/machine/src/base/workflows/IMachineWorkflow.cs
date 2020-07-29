//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;
        
    public interface IMachineWorkflow : IService
    {    
        void Process(PartInstructions src);

        void Render(PartInstructions src);
    }
}