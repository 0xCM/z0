//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public unsafe abstract class CpuState<T>
        where T : CpuState<T>, new()
    {
        protected CpuState()
        {

        }
    }
}