//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;

    public readonly struct WfStepId : IComparable<WfStepId>, IEquatable<WfStepId>, INamed<WfStepId>, ICorrelated<WfStepId>, IChronic<WfStepId>
    {
        /// <summary>
        /// The step's kind classifier
        /// </summary>
        public ulong Kind {get;}

        /// <summary>
        /// The actor/worker name
        /// </summary>
        public asci32 Name {get;}

        [MethodImpl(Inline)]
        public WfStepId(ulong kind, string name)
        {
            Kind = kind;
            Name = name;
        }        

        [MethodImpl(Inline)]
        public bool Equals(WfStepId src)
            => Name == src.Name && Kind == src.Kind;
        
        [MethodImpl(Inline)]
        public int CompareTo(WfStepId src)
            => Kind.CompareTo(src.Kind);
        
        [MethodImpl(Inline)]
        public string Format()
            => Name.Format();

        public uint Hashed
        {        
            [MethodImpl(Inline)]
            get => z.hash(Kind);
        }
        
        public override int GetHashCode()
            => (int)Hashed;

        
        public override bool Equals(object src)
            => src is WfStepId i && Equals(i);

        public override string ToString()
            => Format();
    }
}