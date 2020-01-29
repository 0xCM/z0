//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public enum NatParameterIndex
    {
        Param0 = 0,
        
        Param1 = 1,

        Param2 = 2,
    }

    /// <summary>
    /// Applies to a generic type/method to advertise the natural types over which the type parameter(s) may be closed
    /// </summary>
    public class NatClosuresAttribute : Attribute
    {
        public NatClosuresAttribute(params ulong[] values)
        {
            this.Values = values;
        }

        public NatClosuresAttribute(NatParameterIndex parameter, params ulong[] values)
        {
            this.Values = values;
            this.ParameterIndex = parameter;
        }

        public NatParameterIndex ParameterIndex {get;}
            = 0;

        public ulong[] Values{get;}         
    }

    /// <summary>
    /// Applies to a generic type/method to advertise the natural types over which the type parameter(s) may be closed
    /// </summary>
    public class NatDimClosuresAttribute : Attribute
    {
        public NatDimClosuresAttribute(params ulong[] dimensions)
        {
            this.Dimensions = dimensions;
        }

        public ulong[] Dimensions{get;}         
    }
   
}