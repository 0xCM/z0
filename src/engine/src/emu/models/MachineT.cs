//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Emu
{
    public class Machine<T> : Machine
        where T : unmanaged
    {
        public Cpu<T> Cpu  {get;}

        public Machine(Cpu<T> cpu)
        {
            Cpu = cpu;
        }
    }
}