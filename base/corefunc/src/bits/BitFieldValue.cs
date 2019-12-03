//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a value in a bitfield
    /// </summary>
    public readonly struct BitFieldValue
    {
        /// <summary>
        /// The 0-based position of the bit
        /// </summary>
        public readonly int Index;

        /// <summary>
        /// The name/label identifier
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The value of the bit
        /// </summary>
        public readonly bit Value;

        [MethodImpl(Inline)]
        public BitFieldValue(int Pos, string Name, bit Value)
        {
            this.Index = Pos;
            this.Name = Name;
            this.Value = Value;
        }
        
        public override string ToString()
            => $"({Index.ToString().PadLeft(2, AsciDigits.A0)}, {Name}, {Value})";
    }
}