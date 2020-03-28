//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Canonical;

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
        ulong Width {get;}
 
        /// <summary>
        /// Specifies whether the interval is open on the right and closed on the left, denoted by [Left,Right)
        /// </summary>
        bool RightOpen
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.RightOpen;
        }

        /// <summary>
        /// Specifies whether the interval is open on the left and closed on the right, denoted by (Left,Right]
        /// </summary>
        bool LeftOpen
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.LeftOpen;
        }
    } 

    public interface IInterval<S,T> : IInterval<T>, IFormattable<S>, IPair<S,T>
        where S : struct, IInterval<S,T>
        where T : unmanaged
    {
        S New(T left, T right, IntervalKind kind);

        /// <summary>
        /// Creates an open interval with endpoints from the existing interval
        /// </summary>
        S ToOpen();
            
        /// <summary>
        /// Creates a left-open/right-closed interval with endpoints from the existing interval
        /// </summary>
        S ToLeftOpen();

        /// <summary>
        /// Creates a left-open/right-closed interval with endpoints from the existing interval
        /// </summary>
        S ToRightClosed();

        /// <summary>
        /// Creates a left-open/right-closed interval with endpoints from the existing interval
        /// </summary>
        S ToRightOpen();
        
        /// <summary>
        /// Creates a left-closed interval with endpoints from the existing interval
        /// </summary>
        S ToLeftClosed();

        /// <summary>
        /// Creates a closed interval with endpoints from the existing interval
        /// </summary>
        S ToClosed();         
    }
}