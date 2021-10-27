//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    public sealed class EqClassLookup
    {
        readonly Dictionary<string,EqClass> NameLookup;

        readonly Dictionary<uint,EqClass> SurrogateLookup;

        Index<EqClass> IndexedClasses;

        bool Sealed;

        public EqClassLookup()
        {
            NameLookup = new();
            SurrogateLookup = new();
            IndexedClasses = Index<EqClass>.Empty;
            Sealed = false;
        }

        public ReadOnlySpan<EqClass> Classes
        {
            [MethodImpl(Inline)]
            get => IndexedClasses;
        }

        public ReadOnlySpan<EqClass> Seal()
        {
            IndexedClasses = NameLookup.Values.Array();
            Sealed = true;
            return Classes;
        }

        public bool IsSealed
        {
            [MethodImpl(Inline)]
            get => Sealed;
        }

        public bool Include(EqClass src)
        {
            if(Sealed)
                return false;

            if(NameLookup.TryAdd(src.ClassName, src))
            {
                if(SurrogateLookup.TryAdd(src.ClassId, src))
                    return true;
                else
                    NameLookup.Remove(src.ClassName);
            }

            return false;
        }

        public bool Find(string name, out EqClass dst)
            => NameLookup.TryGetValue(name, out dst);

        public bool Find(uint id, out EqClass dst)
            => SurrogateLookup.TryGetValue(id, out dst);
    }
}