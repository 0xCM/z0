//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct OpUri : IEquatable<OpUri>
    {
        public readonly string Catalog;

        public readonly string Subject;

        public readonly Moniker Id;

        [MethodImpl(Inline)]
        public static bool operator==(OpUri a, OpUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpUri a, OpUri b)
            => !a.Equals(b);

        public static Option<OpUri> Parse(string src)
        {
            var parts = src.Split(fslash());
            if(parts.Length == 3)
            {
                var catalog = parts[0];
                var subject = parts[1];
                var id = Moniker.Parse(parts[2]);
                return Define(catalog, subject, id);
            }
            return none<OpUri>();
        }
        
        [MethodImpl(Inline)]
        public static OpUri Define(string catalog, string subject, Moniker id)        
            => new OpUri(catalog,subject, id);

        [MethodImpl(Inline)]
        OpUri(string catalog, string subject, Moniker id)
        {
            this.Catalog = catalog;
            this.Subject = subject;
            this.Id = id;
        }
        
        public string Format()
            => concat(Catalog, fslash(), Subject, fslash(), Id.Text);
        
        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(OpUri src)
            => string.Compare(Format(), src.Format()) == 0;
        
        public override bool Equals(object obj)
            => obj is OpUri x && Equals(x);
         
        public override int GetHashCode()
            => HashCode.Combine(Catalog,Subject,Id);
    }


}