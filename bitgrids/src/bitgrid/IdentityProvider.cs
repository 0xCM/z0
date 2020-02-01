// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;
    using static FixedWidth;

    readonly struct BitGridIdentity : ITypeIdentityProvider
    {        
        Option<Moniker> DefineGenericIdentity(Type src)
        {
            var name = src.Name.ToLower();
            return name.Contains('`') ? 
                Moniker.Parse(name.LeftOf('`'))
                : Moniker.Parse(name);            
        }

        public Option<Moniker> DefineIdentity(Type src)
        {
            var prefix = string.Empty;
            var width = FixedWidth.None;
            var kind = NumericKind.None;
            var m = 0ul;
            var n = 0ul;
            var t = src.EffectiveType();
            if(!t.IsConstructedGenericType)
                return DefineGenericIdentity(src);

            var def = t.GetGenericTypeDefinition();
            var args = t.GetGenericArguments();
            if(args.Length == 1)
            {
                var arg = args[0];
                kind = arg.NumericKind();
                
                if(def == typeof(BitGrid16<>))
                {
                    width = W16;
                }
                else if(def == typeof(BitGrid32<>))
                {
                    width = W32;
                }
                else if(def == typeof(BitGrid64<>))
                {
                    prefix = "fbg";
                    width = W64;                                                
                }
                else if(def == typeof(BitGrid<>))
                {
                    prefix = "dbg";
                    width = arg.Width();
                }
                return Moniker.Parse($"{prefix}{width.Format()}{Moniker.SegSep}{NumericType.signature(kind)}");
            }
            else if(args.Length == 3)
            {
                m =  args[0].NatValue().Require();
                n = args[1].NatValue().Require();
                kind = args[2].NumericKind();
                if(def == typeof(BitGrid<,,>))
                    prefix = "ndbg";
                else if(def == typeof(BitGrid16<,,>))
                {
                    width = W16;
                    prefix = "nbg";
                }
                else if(def == typeof(BitGrid32<,,>))
                {
                    width = W32;
                    prefix = "nbg";
                }
                else if(def == typeof(BitGrid64<,,>))
                {
                    width = W64;
                    prefix = "nbg";
                }
                else if(def == typeof(BitGrid128<,,>))
                {
                    width = W128;
                    prefix = "nbg";
                }
                else if(def == typeof(BitGrid256<,,>))
                {
                    width = W256;
                    prefix = "nbg";
                }
                else if(def == typeof(SubGrid16<,,>))
                {
                    prefix = "nsg";
                    width = W16;
                }
                else if(def == typeof(SubGrid32<,,>))
                {
                    prefix = "nsg";
                    width = W32;
                }
                else if(def == typeof(SubGrid64<,,>))
                {
                    prefix = "nsg";
                    width = W64;
                }
                else if(def == typeof(SubGrid128<,,>))
                {
                    prefix = "nsg";
                    width = W128;
                }
                else if(def == typeof(SubGrid256<,,>))
                {
                    prefix = "nsg";
                    width = W256;
                }

                return Moniker.Parse($"{prefix}{width.Format()}{m}{Moniker.SegSep}{n}{Moniker.SegSep}{NumericType.signature(kind)}");
            }
            else 
                return Moniker.Parse($"bitgrid_err");                        
        }
    }

}