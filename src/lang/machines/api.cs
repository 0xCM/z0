//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System.Runtime.CompilerServices;
    using System;

    using Z0.Lang;

    using static Root;
    using static core;


    public class StateEnumerator
    {
        // [CmdOp(".dfa-states")]
        // Outcome DfaStates(CmdArgs args)
        // {
        //     var width = 16u;
        //     var states = Dfa.states(width, w8);
        //     var count = states.Length;
        //     Write(string.Format("{0}={1}", "Domain", width));
        //     Write(string.Format("{0}={1}", "Count", count));
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var state = ref skip(states,i);
        //         var buffer = ByteBlock16.Empty;
        //         var v = bitspan.create(width, state, recover<bit>(buffer.Bytes));
        //         Write(string.Format("State[{0}]={1}", i, state));
        //         Write(string.Format("BitVector[{0}].Width={1}", i, v.Width));
        //         Write(string.Format("BitVector[{0}].Bits={1}", i, v.Format()));
        //     }
        //     return true;
        // }
    }

    [ApiHost]
    public readonly partial struct api
    {
        const NumericKind Closure = UnsignedInts;


        // public static TableDfa<Hex5Seq,AsciLetterLoSym> recognizer(string src)
        // {
        //     const AsciLetterLoSym Min = AsciLetterLoSym.a;
        //     const AsciLetterLoSym Max = AsciLetterLoSym.z;

        //     var states = api.states<Hex5Seq>();
        //     var alphabet = rules.alphabet<AsciLetterLoSym>("asci-lo");
        //     var length = src.Length;
        //     if(length > 16)
        //         @throw(string.Format("Strings of length {0} > {1} are not accepted", length, Hex4.Max));

        //     var dim = new GridDim(32,32);
        //     var cells = alloc<Hex5>(dim.M*dim.N);
        //     var g = new DataGrid<Hex5>(dim, alloc<Hex5>(dim.M*dim.N));
        //     var chars = core.span(src);

        //     var col = Hex5.Zero;
        //     for(var row=0; row<length; row++)
        //     {
        //         ref readonly var c = ref skip(chars,row);
        //         ref readonly var s = ref @as<char,AsciLetterLoSym>(c);
        //         if(s >= Min && s <= Max)
        //             g[row,col] = (byte)((ushort)s - (ushort)Min);
        //         else
        //             @throw("Only lowercase asci characters are supported");
        //     }

        //     return new TableDfa<Hex5Seq, AsciLetterLoSym>()
        // }
    }
}