//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISampleDefaults<T>
        where T : unmanaged
    {
        /// <summary>
        /// The domain of potential values
        /// </summary>
        Interval<T> SampleDomain {get;}
    }
}