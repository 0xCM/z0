//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;    
 
    public static partial class Data
    {        
        const int IndexWidth = 8;

        const int ByteSwapIndex = 0*IndexWidth;

        const int DecIndex = 1*IndexWidth;

        const int IncIndex = 2*IndexWidth;

        const int PackIndex = 3*IndexWidth;

        const int UnitsIndex = 4*IndexWidth;

        const int LastIndex = UnitsIndex + IndexWidth;

        const int ResCount = LastIndex;

        static readonly DataResource[] Descriptions = new DataResource[ResCount];
        
        static bool Initialized = false;

        public static IEnumerable<DataResource> GetDescriptions()
        {
            lock(Descriptions)
            {
                if(!Initialized)
                {
                    try
                    {
                        iter(typeof(Data).DeclaredStaticMethods().Attributed<DataRegistryAttribute>(), m => m.Invoke(null, new object[]{}));
                        Initialized = true;
                    }
                    catch(Exception e)
                    {
                        error(e);
                    }
                }
            }

            if(Initialized)
                foreach(var d in Descriptions)
                    if(!d.IsEmpty)
                        yield return d;                        
        }


        [MethodImpl(Inline)]
        static unsafe void Register(int index, string name, ReadOnlySpan<byte> src)
            => Descriptions[index] = DataResource.Define(name, src);

        [MethodImpl(Inline)]
        static string resid(string basename, ITypeNat w, PrimalKind kind)
            => ResourceIdentity.define(basename, w, kind);
        
        [MethodImpl(Inline)]
        static string resid(string basename, ITypeNat w1, ITypeNat w2, PrimalKind kind)
            => ResourceIdentity.define(basename, w1,w2, kind);

    }

}