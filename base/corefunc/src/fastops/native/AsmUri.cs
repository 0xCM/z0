//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct AsmUri : IEquatable<AsmUri>
    {
        public readonly string Catalog;

        public readonly string Subject;

        public readonly Moniker Id;

        [MethodImpl(Inline)]
        public static bool operator==(AsmUri a, AsmUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(AsmUri a, AsmUri b)
            => !a.Equals(b);

        public static Option<AsmUri> Parse(string src)
        {
            var parts = src.Split(fslash());
            if(parts.Length == 3)
            {
                var catalog = parts[0];
                var subject = parts[1];
                var id = Moniker.Parse(parts[2]);
                return Define(catalog,subject,id);
            }
            return default;
        }
        
        [MethodImpl(Inline)]
        public static AsmUri Define(string catalog, string subject, Moniker id)        
            => new AsmUri(catalog,subject, id);

        [MethodImpl(Inline)]
        AsmUri(string catalog, string subject, Moniker id)
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
        public bool Equals(AsmUri src)
            => string.Compare(Format(), src.Format()) == 0;
        
        public override bool Equals(object obj)
            => obj is AsmUri x && Equals(x);
         
        public override int GetHashCode()
            => HashCode.Combine(Catalog,Subject,Id);
    }


}