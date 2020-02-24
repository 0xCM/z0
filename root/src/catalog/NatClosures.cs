//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    [Flags]
    public enum NatClosureKind : byte
    {
        None = 0,
        
        /// <summary>
        /// Indicates closure is specified for an explicitly-specified set naturals
        /// </summary>
        Individuals = 1,

        /// <summary>
        /// Indicates closure is specified for an inclusive range of naturals
        /// </summary>
        Range = 2,

        /// <summary>
        /// Indicates closure is specified for an inclusive range of natural powers of 2
        /// </summary>
        Powers2 = 3,
    }

    /// <summary>
    /// Applies to a generic type/method to advertise the types over which type parameter(s) may be closed
    /// </summary>
    public class NatClosuresAttribute : Attribute
    {
        /// <summary>
        /// Defines the closure for a range
        /// </summary>
        /// </summary>
        /// <param name="min">The minimum value in the range</param>
        /// <param name="max">The maximum value in the range</param>
        /// <param name="kind">The range classification</param>
        public NatClosuresAttribute(ulong min, ulong max, NatClosureKind kind = NatClosureKind.Powers2)
        {
            this.ClosureKind = kind;
            this.NatValues = new ulong[]{min,max};
        }

        /// <summary>
        /// Defines the closure for an indentified set of individuals
        /// </summary>
        /// <param name="individuals">The individual values</param>
        public NatClosuresAttribute(params uint[] individuals)
        {
            this.ClosureKind = NatClosureKind.Individuals;
            this.NatValues = new ulong[individuals.Length];
            for(var i=0; i<individuals.Length; i++)
                NatValues[i] = individuals[i];
        }

        /// <summary>
        /// Used when one of the other constructors wont' do
        /// </summary>
        /// <param name="individuals">The individual values</param>
        public NatClosuresAttribute(NatClosureKind kind, params ulong[] values)
        {
            this.ClosureKind = kind;
            this.NatValues = values;
        }

        /// <summary>
        /// The nature of the the closure: individual, aribitrary range, pow2 range
        /// </summary>
        public NatClosureKind ClosureKind {get;}

        /// <summary>
        /// For closure over individuals, specifies their corresponding integral values;
        /// for closure over a range the first element specifies the minimum inclusive value
        /// and the second element specifies the maximum inclusive value
        /// </summary>
        public ulong[] NatValues {get;}
    }    
}