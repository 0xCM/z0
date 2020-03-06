//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    /// <summary>
    /// Reifies a natural prime base raised to a natural power
    /// </summary>
    public readonly struct PrimePow<P,E> : ITypeNat
        where E : unmanaged, ITypeNat
        where P : unmanaged, ITypeNat, INatPrime<P>
    {
        public static PrimePow<P,E> Rep => default;

        public static Pow<P,E> Seq => default;

        public static ulong Value => Seq.NatValue;

        public ITypeNat rep 
            => Rep;

        public NatSeq Sequence 
            => Seq.Sequence;

        public ulong NatValue 
            => Seq.NatValue;

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }
}