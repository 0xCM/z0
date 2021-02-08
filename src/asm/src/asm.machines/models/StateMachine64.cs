//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IStateMachine<T,S>
    {
        S Next(T input);
    }

    public readonly partial struct StateMachines
    {
        public sealed class Cpu : WfService<Cpu,Cpu>
        {

        }
    }
}