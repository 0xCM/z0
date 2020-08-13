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

    public readonly struct WfStepId : 
        IComparable<WfStepId>, 
        IEquatable<WfStepId>, 
        INamed<WfStepId>, 
        ICorrelated<WfStepId>, 
        IChronic<WfStepId>, 
        ITextual
    {
        public static WfStepId Empty 
            => new WfStepId(typeof(void));
            
        /// <summary>
        /// The step's kind classifier
        /// </summary>
        public ulong Kind {get;}

        /// <summary>
        /// The step name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The invoking member
        /// </summary>
        public string Caller {get;}

        [MethodImpl(Inline)]
        public WfStepId(Type host, [CallerFilePath] string caller = null)
        {
            Kind = (ulong)host.MetadataToken;
            Name = host.Name;
            Caller = Path.GetFileNameWithoutExtension(caller);
        }        

        [MethodImpl(Inline)]
        public WfStepId(ulong kind, string name, [CallerFilePath] string caller = null)
        {
            Kind = kind;
            Name = name;
            Caller = Path.GetFileNameWithoutExtension(caller);
        }        

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.blank(Name);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Name);
        }

        [MethodImpl(Inline)]
        public bool Equals(WfStepId src)
            => Name == src.Name && Kind == src.Kind;
        
        [MethodImpl(Inline)]
        public int CompareTo(WfStepId src)
            => Kind.CompareTo(src.Kind);
        
        [MethodImpl(Inline)]
        public string Format()
            => Name;
        
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