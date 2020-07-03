//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    
    public abstract class t_asmd<U> : UnitTest<U,CheckVectorBits, ICheckVectorBits>
        where U : t_asmd<U>, new()
    {     
        protected t_asmd()
        {
            UnitDataDir.Clear();   
        }
    }
}
