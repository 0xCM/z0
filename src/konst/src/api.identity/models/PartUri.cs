//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = ApiIdentity;

    /// <summary>
    /// Uri for .net clr assembly
    /// </summary>
    public readonly struct PartUri : IApiUri<PartUri>, INullary<PartUri>
    {
        /// <summary>
        /// The assembly identifier, constrained to the defining enumeration
        /// </summary>
        public readonly PartId Id;

        /// <summary>
        /// The uri content
        /// </summary>
        public string UriText {get;}

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Id == PartId.None || text.empty(UriText);
        }

        PartUri INullary<PartUri>.Zero
            => Empty;

        [MethodImpl(Inline)]
        internal PartUri(PartId id)
        {
            Id = id;
            UriText = id != 0 ? id.Format() : EmptyString;
        }

        [MethodImpl(Inline)]
        public bool Equals(PartUri src)
            => api.equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(PartUri other)
            => api.compare(this, other);

        public override int GetHashCode()
            => api.hash(this);

        public override bool Equals(object obj)
            => api.equals(this, obj);

        public override string ToString()
            => UriText;

        public static PartUri Empty
            => new PartUri(0);
    }
}