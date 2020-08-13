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

    public readonly struct WfStepId<T> : 
        IComparable<WfStepId<T>>, 
        IEquatable<WfStepId<T>>, 
        INamed<WfStepId<T>>, 
        ICorrelated<WfStepId<T>>, 
        IChronic<WfStepId<T>>, 
        ITextual        
    {
        public static WfStepId<T> Empty 
            => new WfStepId<T>(typeof(T));

        [MethodImpl(Inline)]
        public static implicit operator WfStepId(WfStepId<T> src)            
            => new WfStepId(src.Host, src.Caller);
        
        public Type Host {get;}
        
        /// <summary>
        /// The invoking member
        /// </summary>
        public string Caller {get;}

        /// <summary>
        /// The step name
        /// </summary>
        public string Name 
            => Host.Name; 

        [MethodImpl(Inline)]
        public WfStepId(Type t, [CallerFilePath] string caller = null)
        {
            Host = t;
            Caller = Path.GetFileNameWithoutExtension(caller);
        }        

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Host == null || Host.IsEmpty();
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Host != null && !Host.IsEmpty();
        }

        [MethodImpl(Inline)]
        public bool Equals(WfStepId<T> src)
            => Host == src.Host;
        
        [MethodImpl(Inline)]
        public int CompareTo(WfStepId<T> src)
            => Host.FullName.CompareTo(src.Host.FullName);
        
        [MethodImpl(Inline)]
        public string Format()
            => Name;

        [MethodImpl(Inline)]
        public string Format(bool full)
            => full ? Host.FullName : Host.Name;

        public uint Hashed
        {        
            [MethodImpl(Inline)]
            get => (uint)Host.GetHashCode();
        }
        
        public override int GetHashCode()
            => (int)Hashed;

        
        public override bool Equals(object src)
            => src is WfStepId x && Equals(x);

        public override string ToString()
            => Format();
    }
}