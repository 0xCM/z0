//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    // public interface ISampleDefaults
    // {


    // }

    public interface ISampleDefaults<T> //: ISampleDefaults
        where T : unmanaged
    {
        /// <summary>
        /// The domain of potential values
        /// </summary>
        Interval<T> SampleDomain {get;}
    }
}