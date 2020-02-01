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

    /// <summary>
    /// Identifies a parameter that accepts an immediate value
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class ImmAttribute : Attribute
    {


    }

    /// <summary>
    /// Identifies a parameter that accepts an immediate shift count
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class ShiftAttribute : ImmAttribute
    {

        public ShiftAttribute(bool bits)
        {
            if(bits)
            {
                Bits = true;
                Bytes = false;
            }
            else
            {
                Bits = false;
                Bytes = true;
            }
        }

        public ShiftAttribute()
            : this(true)
        {}

        public bool Bits {get;}

        public bool Bytes {get;}
    }
}