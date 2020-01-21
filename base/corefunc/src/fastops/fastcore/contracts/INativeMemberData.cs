//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static zfunc;

    public interface INativeMemberData
    {
        /// <summary>
        /// The deconstructed method
        /// </summary>
        MethodInfo Method {get;}

        /// <summary>
        /// The location of the member data relative to the native source
        /// </summary>
        MemoryRange Location {get;}
            
        /// <summary>
        /// The memory content
        /// </summary>
        AsmCode Code {get;}

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        ulong StartAddress 
            => Location.Start;

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        ulong EndAddress 
            => Location.End;

        ulong Length 
            => Location.Length;

        bool IsEmpty 
            => Length == 0;

        Moniker Id 
            => Code.Id;

        string Label 
            => Code.Label;

    }


}