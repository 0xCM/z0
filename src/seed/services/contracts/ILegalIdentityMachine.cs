//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public interface ILegalIdentityOption
    {
        char TypeArgsOpen {get;}

        char TypeArgsClose {get;}

        char ArgsOpen {get;}

        char ArgsClose {get;}

        char ArgSep {get;}
    }
    
    public interface ILegalIdentityMachine : ILegalIdentityOption
    {
        string Manufacture(OpIdentity src);
        // {
        //     var length = src.IdentityText.Length;
        //     Span<char> dst = stackalloc char[length];
        //     for(var i=0; i< length; i++)
        //     {
        //         var c = src.IdentityText[i];
        //         switch(c)
        //         {
        //             case IDI.TypeArgsOpen:
        //                 dst[i] = TypeArgsOpen;
        //             break;
        //             case IDI.TypeArgsClose:
        //                 dst[i] = TypeArgsClose;
        //             break;
        //             case IDI.ArgsOpen:
        //                 dst[i] = ArgsOpen;
        //             break;
        //             case IDI.ArgsClose:
        //                 dst[i] = ArgsClose;
        //             break;
        //             case IDI.ArgSep:
        //                 dst[i] = ArgSep;
        //             break;
        //             default:
        //                 dst[i] = c;
        //             break;
        //         }
        //     }
        //     return new string(dst.Trim());
        // }
    }
}