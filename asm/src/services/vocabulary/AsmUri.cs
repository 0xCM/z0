//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct AsmUri
    {
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
        
        public static AsmUri Define(string catalog, string subject, Moniker id)        
            => new AsmUri(catalog,subject, id);

        AsmUri(string catalog, string subject, Moniker id)
        {
            this.Catalog = catalog;
            this.Subject = subject;
            this.Id = id;
        }
        
        public readonly string Catalog;

        public readonly string Subject;

        public readonly Moniker Id;

        public string Format()
            => concat(Catalog, fslash(), Subject, fslash(), Id.Text);
        
        public override string ToString()
            => Format();
    }


}