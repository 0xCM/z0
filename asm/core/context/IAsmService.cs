//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        

    /// <summary>
    /// Characterizes a contextual asm service where caller-managed lifecyle is not needed
    /// </summary>
    public interface IAsmService :  IService<IAsmContext>
    {
    
    }


    /// <summary>
    /// Characterizes contexutal asm service with caller-managed lifecycle
    /// </summary>
    public interface IAsmServiceAllocation : IAsmService, IServiceAllocation<IAsmContext>
    {

    }
}