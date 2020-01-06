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

    public enum ParameterDirection
    {
        Default,

        In = 1,

        Out = 2
    }

    public interface INativeMemberData
    {
        /// <summary>
        /// The deconstructed method
        /// </summary>
        MethodInfo Method {get;}

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        ulong StartAddress {get;}

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        ulong EndAddress {get;}

        /// <summary>
        /// The memory content
        /// </summary>
        byte[] Body {get;}

        ulong Length 
            => EndAddress -StartAddress;        

        bool IsEmpty {get;}
    }

}