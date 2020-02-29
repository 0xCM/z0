//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Characterizes a contiguous segment of homogenous values that lie within
    /// left and right boundaries 
    /// </summary>
    /// <remarks>
    /// Note that extended real numbers may also serve as endpoints,enabling representations such as (-∞,3] and (-3, ∞).
    /// </remarks>
    public interface IInterval<T>
        where T : unmanaged
    {    
        /// <summary>
        ///  The left endpoint
        /// </summary>
        T Left {get;}

        /// <summary>
        ///  Specifies whether the interval contains its left endpoint
        /// </summary>
        bool LeftClosed {get;}

        /// <summary>
        ///  The right endpoint
        /// </summary>
        T Right {get;}

        /// <summary>
        ///  Specifies whether the interval contains its right endpoint
        /// </summary>
        bool RightClosed {get;}

        /// <summary>
        /// The interval classification
        /// </summary>
        IntervalKind Kind {get;}

        /// <summary>
        ///  Specifies whether the interval is closed
        /// </summary>
        bool Closed { [MethodImpl(Inline)] get => Kind == IntervalKind.Closed;}

        /// <summary>
        ///  Specifies whether the interval is open
        /// </summary>
        bool Open {[MethodImpl(Inline)] get => Kind == IntervalKind.Open;}

        /// <summary>
        /// The interval width
        /// </summary>
        ulong Width
        {
            [MethodImpl(Inline)]
            get => convert<T,ulong>(Right) - convert<T,ulong>(Left);
        }
    }

 

}