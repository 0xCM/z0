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
    public readonly struct CmdArgValidity
    {
        /// <summary>
        /// The validation result
        /// </summary>
        public ArgValidityState State {get;}

        /// <summary>
        /// Requires invariant satisfaction
        /// </summary>
        /// <param name="invariant">The outcome of invariant evaluation</param>
        /// <param name="failed">The state to yield if the invariant does not hold</param>
        [MethodImpl(Inline)]
        public static CmdArgValidity require(bool invariant, ArgValidityState failed)
            => invariant ? new CmdArgValidity(Valid) : new CmdArgValidity(failed);

        [MethodImpl(Inline)]
        public CmdArgValidity(ArgValidityState kind)
            => State = kind;

        [MethodImpl(Inline)]
        public CmdArgValidity(ArgValidityStatus kind)
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
        public bool Equals(CmdArgValidity src)
            => State == src.State;

        public override string ToString()
            => Format();

        public override bool Equals(object src)
            => src is CmdArgValidity v && Equals(v);

        public override int GetHashCode()
            => (int)Hashed;

        public static CmdArgValidity Default
            => default;

        [MethodImpl(Inline)]
        public static implicit operator CmdArgValidity(ArgValidityState src)
            => new CmdArgValidity(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdArgValidity src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator ArgValidityState(CmdArgValidity src)
            => src.State;

        [MethodImpl(Inline)]
        public static implicit operator ArgValidityStatus(CmdArgValidity src)
            => src.Status;

        [MethodImpl(Inline)]
        public static implicit operator bool(CmdArgValidity src)
            => src.IsValid;

        [MethodImpl(Inline)]
        public static bool operator true(CmdArgValidity src)
            => src.IsValid;

        [MethodImpl(Inline)]
        public static bool operator false(CmdArgValidity src)
            => src.IsInvalid;

        [MethodImpl(Inline)]
        public static CmdArgValidity operator +(CmdArgValidity a, CmdArgValidity b)
            => new CmdArgValidity(a.State | b.State);

        [MethodImpl(Inline)]
        public static CmdArgValidity operator !(CmdArgValidity a)
            => new CmdArgValidity((a.State == Valid) ? Invalid : a.State);

        [MethodImpl(Inline)]
        public static CmdArgValidity operator ~(CmdArgValidity a)
            => new CmdArgValidity(~a.State);

        [MethodImpl(Inline)]
        public static CmdArgValidity operator &(CmdArgValidity a, CmdArgValidity b)
            => new CmdArgValidity(a.State & b.State);

        [MethodImpl(Inline)]
        public static CmdArgValidity operator |(CmdArgValidity a, CmdArgValidity b)
            => new CmdArgValidity(a.State | b.State);

        [MethodImpl(Inline)]
        public static CmdArgValidity operator ^(CmdArgValidity a, CmdArgValidity b)
            => new CmdArgValidity(a.State ^ b.State);

        [MethodImpl(Inline)]
        public static bool operator ==(CmdArgValidity a, CmdArgValidity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(CmdArgValidity a, CmdArgValidity b)
            => !a.Equals(b);
    }
}