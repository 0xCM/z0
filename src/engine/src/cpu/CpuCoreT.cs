//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class CpuCore<T> : CpuCore
        where T : unmanaged
    {
        public CpuCore(uint id)
            : base(id)
        {

        }
    }
}