//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    public class ProcessorKinds
    {
        /// <summary>
        /// Acceppts source:S and produces target:T
        /// </summary>
        public readonly struct Canonical<S,T>
        {


        }

        /// <summary>
        /// Accepts source:num[S] and produces target:num[T]
        /// </summary>
        public readonly struct Numeric<S,T>
            where S : unmanaged
            where T : unmanaged
        {
            
        }

        /// <summary>
        /// Accepts source:Span[S] and populates target:Span[T]
        /// </summary>
        public readonly struct SpanProcessor<S,T>
        {

            
        }

        /// <summary>
        /// Accepts source:S and populates target:Span[T]
        /// </summary>
        public readonly struct SpanTarget<S,T>
        {

            
        }

        /// <summary>
        /// Accepts source:Span[S] and populates target:T
        /// </summary>
        public readonly struct SpanSource<S,T>
        {

            
        }

    }

}