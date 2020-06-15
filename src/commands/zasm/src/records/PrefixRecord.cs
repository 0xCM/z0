//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = PrefixFieldId;
    using R = PrefixRecord;

    public readonly struct PrefixRecord : IRecord<F,R>
    {
        public PrefixRecord(
            int Sequence, 
            OpCodeId Id, 
            bool Lock, 
            bool Xacquire, 
            bool Xrelease, 
            bool Rep, 
            bool Repne, 
            bool Bnd, 
            bool HintTaken, 
            bool Notrack, 
            MandatoryPrefix Mandatory
            )
        {

            this.Sequence = Sequence;
            this.Id = Id;
            this.Lock = Lock;
            this.Xacquire = Xacquire;
            this.Xrelease = Xrelease;
            this.Rep = Rep;
            this.Repne = Repne;
            this.Bnd = Bnd;
            this.HintTaken = HintTaken;
            this.Notrack = Notrack;
            this.Mandatory = Mandatory;
        }

		public int Sequence {get;}

        public readonly OpCodeId Id;

        public readonly bool Lock;

        public readonly bool Xacquire;

        public readonly bool Xrelease;

        public readonly bool Rep;

        public readonly bool Repne;

        public readonly bool Bnd;

        public readonly bool HintTaken;

        public readonly bool Notrack;

        public readonly MandatoryPrefix Mandatory;
    }
}