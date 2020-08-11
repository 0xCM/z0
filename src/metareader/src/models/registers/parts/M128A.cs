//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Runtime.InteropServices;
 
    [StructLayout(LayoutKind.Sequential)]
    public struct M128A : IEquatable<M128A>
    {
        public ulong Low;
        public ulong High;

        public void Clear()
        {
            Low = 0;
            High = 0;
        }

        public static bool operator ==(M128A left, M128A right) => left.Equals(right);

        public static bool operator !=(M128A left, M128A right) => !(left == right);

        public override bool Equals(object obj) => obj is M128A other && Equals(other);

        public bool Equals(M128A other) => Low == other.Low && High == other.High;

        public override int GetHashCode() 
            => base.GetHashCode();
    }        
}