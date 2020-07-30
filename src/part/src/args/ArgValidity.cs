//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static ArgValidityState;
    
    /// <summary>
    /// Captures argument validation outcome
    /// </summary>
    public readonly struct ArgValidity
    {        
        /// <summary>
        /// The validation result
        /// </summary>
        public readonly ArgValidityState State;      

        /// <summary>
        /// Requires invariant satisfaction
        /// </summary>
        /// <param name="invariant">The outcome of invariant evaluation</param>
        /// <param name="failed">The state to yield if the invariant does not hold</param>
        [MethodImpl(Inline)]
        public static ArgValidity require(bool invariant, ArgValidityState failed)
            => invariant ? new ArgValidity(Valid) : new ArgValidity(failed);

        [MethodImpl(Inline)]
        public static implicit operator ArgValidity(ArgValidityState src)
            => new ArgValidity(src);

        [MethodImpl(Inline)]
        public static implicit operator string(ArgValidity src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator ArgValidityState(ArgValidity src)
            => src.State;

        [MethodImpl(Inline)]
        public static implicit operator ArgValidityStatus(ArgValidity src)
            => src.Status;

        [MethodImpl(Inline)]
        public static implicit operator bool(ArgValidity src)
            => src.IsValid;

        [MethodImpl(Inline)]
        public static bool operator true(ArgValidity src)
            => src.IsValid;

        [MethodImpl(Inline)]
        public static bool operator false(ArgValidity src)
            => src.IsInvalid;

        [MethodImpl(Inline)]
        public static ArgValidity operator +(ArgValidity a, ArgValidity b) 
            => new ArgValidity(a.State | b.State);

        [MethodImpl(Inline)]
        public static ArgValidity operator !(ArgValidity a) 
            => new ArgValidity((a.State == Valid) ? Invalid : a.State);

        [MethodImpl(Inline)]
        public static ArgValidity operator ~(ArgValidity a) 
            => new ArgValidity(~a.State);

        [MethodImpl(Inline)]
        public static ArgValidity operator &(ArgValidity a, ArgValidity b) 
            => new ArgValidity(a.State & b.State);

        [MethodImpl(Inline)]
        public static ArgValidity operator |(ArgValidity a, ArgValidity b) 
            => new ArgValidity(a.State | b.State);

        [MethodImpl(Inline)]
        public static ArgValidity operator ^(ArgValidity a, ArgValidity b) 
            => new ArgValidity(a.State ^ b.State);

        [MethodImpl(Inline)]
        public static bool operator ==(ArgValidity a, ArgValidity b) 
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(ArgValidity a, ArgValidity b) 
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public ArgValidity(ArgValidityState kind)
            => State = kind;

        [MethodImpl(Inline)]
        public ArgValidity(ArgValidityStatus kind)
            => State = (ArgValidityState)kind;

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => (uint)State;
        }
        
        public bool IsValid
        {
            [MethodImpl(Inline)]
            get => State == Valid;
        }
        
        public bool IsInvalid
        {
            [MethodImpl(Inline)]
            get => State != Valid;
        }

        public ArgValidityStatus Status
        {
            [MethodImpl(Inline)]
            get => IsValid ? ArgValidityStatus.Valid : ArgValidityStatus.Invalid;
        }

        [MethodImpl(Inline)]
        public string Format()
            => State.ToString();

        [MethodImpl(Inline)]
        public bool Equals(ArgValidity src)
            => State == src.State;

        public override string ToString()
            => Format();

        public override bool Equals(object src)
            => src is ArgValidity v && Equals(v);
        
        public override int GetHashCode()
            => (int)Hashed;

        public static ArgValidity Default 
            => default;
    }
}