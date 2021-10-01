//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static GVGrammarTerms;
    using R = Rules;

    using T = GVGrammarTerms;

    public class GVGrammar
    {

    }

    /// <summary>
    /// https://graphviz.org/doc/info/lang.html
    /// </summary>
    public class GVGrammarTerms
    {
        public abstract class ID
        {

        }

        public abstract class ID<T> : ID
        {

        }

        public class graph
        {

        }

        public class statement
        {

        }

        public class edge_statement : statement
        {

        }

        public class attr_statement : statement
        {

        }


        public class node_statement : statement
        {

        }

        public class assignment_statement<T> : statement
        {
            public ID<T> Left;

            public ID<T> Right;
        }

        public class statement_list
        {

        }

        public class term_delimiter
        {
            public string Value => ";";
        }

        public class subgraph
        {

        }

        public class open_list
        {
            public string Value => "[";
        }

        public class close_list
        {
            public string Value => "]";
        }

        public class open_group
        {
            public string Value => "{";
        }

        public class close_group
        {
            public string Value => "}";
        }


        public class port
        {
            public compass_pt direction;
        }

        public class labeled_port<T> : port
        {
            public ID<T> ID;
        }

        public enum keyword : byte
        {
            node,

            edge,

            digraph,

            subgraph,

            strict
        }


        [SymSource]
        public enum compass_pt : byte
        {
            [Symbol("n")]
            n,

            [Symbol("ne")]
            ne,

            [Symbol("e")]
            e,

            [Symbol("se")]
            se,

            [Symbol("s")]
            s,

            [Symbol("sw")]
            sw,

            [Symbol("w")]
            w,

            [Symbol("nw")]
            nw,

            [Symbol("c")]
            c,

            [Symbol("_")]
            _
        }

    }

    public partial class GVDot
    {
        public class Graph
        {
            public uint Id {get;}

        }

        public class Digraph : Graph
        {

        }

    }
}